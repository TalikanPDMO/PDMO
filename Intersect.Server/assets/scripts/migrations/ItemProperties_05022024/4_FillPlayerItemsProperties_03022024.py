import json
import sqlite3


# This script look all the items in gamedata.db
# Players with those items will now have a max roll of the items stats in their inventory, bank, bag, etc ...
# Then, clean the useless data related to the format change

# /!\ LAUNCH AFTER RUNNING THE SERVER CONSOLE MIGRATION AND AFTER ALL THE OTHERS SCRIPTS ABOUT Effects, Stats, Vitals /!\

# Always SHUTDOWN THE SERVER when running migrations scripts

gamedata_path = "/home/resources/gamedata.db"
playerdata_path = "/home/resources/playerdata.db"

print("********* START OF MIGRATION *********")
try:
	# existing DB
	gameCon = sqlite3.connect(gamedata_path)
	gameCur = gameCon.cursor()
	playerCon = sqlite3.connect(playerdata_path)
	playerCur = playerCon.cursor()
	print("Connection to database OK")

	gameCur.execute("SELECT Id, Name, ItemType, StatsGiven, VitalsGiven, Effects FROM Items")
	items = gameCur.fetchall()
	print(len(items), " items detected")
	print("Now updating player items ...")
	i = 0
	for item in items:
		i += 1
		print("ITEM ", i, "/", len(items), " : ", item[1], " ... ", end=" ")
		item_properties_json = ""
		if item[2] == 1:  # Update only Equipment Type (which is 1)
			item_properties = {}

			stats_base = json.loads(item[3])
			item_properties["Stats"] = []
			for s in stats_base:
				item_properties["Stats"].append(max(s[0], s[1]))

			vitals_base = json.loads(item[4])
			item_properties["Vitals"] = []
			for v in vitals_base:
				item_properties["Vitals"].append(max(v[0], v[1]))

			effects_base = json.loads(item[5])
			item_properties["Effects"] = []
			for e in effects_base:
				item_properties["Effects"].append([e["Type"], max(e["Min"], e["Max"])])

			item_properties_json = json.dumps(item_properties)
			playerCur.execute("UPDATE Player_Items SET ItemProperties = json_patch(ItemProperties, ?) WHERE ItemId = ?",
				[item_properties_json, item[0]])
			playerCur.execute(
				"UPDATE Player_Bank SET ItemProperties = json_patch(ItemProperties, ?) WHERE ItemId = ?",
				[item_properties_json, item[0]])
			playerCur.execute(
				"UPDATE Guild_Bank SET ItemProperties = json_patch(ItemProperties, ?) WHERE ItemId = ?",
				[item_properties_json, item[0]])
			playerCur.execute(
				"UPDATE Bag_Items SET ItemProperties = json_patch(ItemProperties, ?) WHERE ItemId = ?",
				[item_properties_json, item[0]])
		else:
			playerCur.execute("UPDATE Player_Items SET ItemProperties = ? WHERE ItemId = ?",
			                  [item_properties_json, item[0]])
			playerCur.execute(
				"UPDATE Player_Bank SET ItemProperties = ? WHERE ItemId = ?",
				[item_properties_json, item[0]])
			playerCur.execute(
				"UPDATE Guild_Bank SET ItemProperties = ? WHERE ItemId = ?",
				[item_properties_json, item[0]])
			playerCur.execute(
				"UPDATE Bag_Items SET ItemProperties = ? WHERE ItemId = ?",
				[item_properties_json, item[0]])
		playerCon.commit()
		print(" DONE ")
	print("Conversion of all Item Properties done successfully ...")
	print("Now cleaning useless item properties data on player database  ...")
	playerCur.execute(
		"UPDATE Player_Items SET ItemProperties = '' WHERE Quantity = 0 OR hex(ItemId) = '00000000000000000000000000000000'")
	playerCur.execute(
		"UPDATE Player_Bank SET ItemProperties = ''  WHERE Quantity = 0 OR hex(ItemId) = '00000000000000000000000000000000'")
	playerCur.execute(
		"UPDATE Guild_Bank SET ItemProperties = '' WHERE Quantity = 0 OR hex(ItemId) = '00000000000000000000000000000000'")
	playerCur.execute(
		"UPDATE Bag_Items SET ItemProperties = ''  WHERE Quantity = 0 OR hex(ItemId) = '00000000000000000000000000000000'")
	playerCon.commit()
	print("Cleaning done successfully")
except sqlite3.Error as error:
	print("Error while processing :")
	print(error)
finally:
	gameCon.close()
	playerCon.close()

print("********* END OF MIGRATION *********")