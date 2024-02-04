import json
import sqlite3


# This script look all the items in gamedata.db
# Players with those items will now have a max roll of the items stats in their inventory, bank, bag, etc ...
# Then, clean the useless data related to the format change
# Finally, delete all useless columns related to the format change

# /!\ LAUNCH AFTER RUNNING THE SERVER CONSOLE MIGRATION AND AFTER ALL THE OTHERS SCRIPTS ABOUT Effects, Stats, Vitals /!\

# Always SHUTDOWN THE SERVER when running migrations scripts

gamedata_path = "/home/resources/gamedata.db"
playerdata_path = "/home/resources/playerdata.db"

print("********* START OF MIGRATION *********")
try:
	# existing DB
	gameCon = sqlite3.connect(gamedata_path)
	gameCur = gameCon.cursor()
	print("Connection to database OK")

	gameCur.execute("SELECT Id, Name, VitalsGiven  FROM Items ")
	items = gameCur.fetchall()
	print(len(items), " items detected")
	print("Now updating items ...")
	for item in items:
		current_vitals = json.loads(item[2])
		vitals_given = []
		for v in current_vitals:
			vitals_given.append([v, v])
		gameCur.execute("UPDATE Items SET VitalsGiven = ? WHERE Id = ?", [json.dumps(vitals_given), item[0]])
	gameCon.commit()
	print("All the items were successfully updated")
except sqlite3.Error as error:
	print("Error while processing :")
	print(error)
finally:
	gameCon.close()

print("********* END OF MIGRATION *********")