import sqlite3
from datetime import datetime
import json

# This script look all the items in gamedata.db that have extra effects and then update the playerdata.db
# Players with those items will now have a max roll of the items effects in their inventory, bank, bag, etc ...

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

	gameCur.execute("SELECT Id, Name, Effects FROM Items WHERE Effects != '[]'")
	items = gameCur.fetchall()
	print("All items with Extra Effects fetched, Total: ", len(items))
	for item in items:
		print("ITEM : ", item[1], " ... ", end=" ")
		effects_base = json.loads(item[2])
		effects = []
		for e in effects_base:
			effects.append([e["Type"], e["Max"]])
		json_effects = json.dumps(effects)
		playerCur.execute("UPDATE Player_Items SET Effects = ? WHERE Effects = '[]' AND ItemId = ?",
		                  [json_effects, item[0]])
		playerCur.execute(
			"UPDATE Player_Bank SET Effects = ? WHERE Effects = '[]' AND ItemId = ?",
			[json_effects, item[0]])
		playerCur.execute(
			"UPDATE Guild_Bank SET Effects = ? WHERE Effects = '[]' AND ItemId = ?",
			[json_effects, item[0]])
		playerCur.execute(
			"UPDATE Bag_Items SET Effects = ? WHERE Effects = '[]' AND ItemId = ?",
			[json_effects, item[0]])
		playerCon.commit()
		print(" DONE ")
except sqlite3.Error as error:
	print("Error while processing :")
	print(error)
finally:
	gameCon.close()
	playerCon.close()

print("********* END OF MIGRATION *********")