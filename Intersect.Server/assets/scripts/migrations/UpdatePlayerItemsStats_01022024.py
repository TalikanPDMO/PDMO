import sqlite3
from datetime import datetime
import json

# This script look all the items in gamedata.db
# Players with those items will now have a max roll of the items stats in their inventory, bank, bag, etc ...

# /!\ LAUNCH AFTER RUNNING THE SERVER CONSOLE MIGRATION, when all item ranges in the editor are configured as we want /!\

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

	gameCur.execute("SELECT Id, Name, StatsGiven FROM Items")
	items = gameCur.fetchall()
	print(len(items), " items detected")
	print("Now updating player items ...")
	i = 0
	for item in items:
		i += 1
		print("ITEM ", i, "/", len(items), " : ", item[1], " ... ", end=" ")
		stats_base = json.loads(item[2])
		stats = []
		for s in stats_base:
			stats.append(s[1])
		json_stats = json.dumps(stats)
		playerCur.execute("UPDATE Player_Items SET StatBuffs = ? WHERE ItemId = ?",
			[json_stats, item[0]])
		playerCur.execute(
			"UPDATE Player_Bank SET StatBuffs = ? WHERE ItemId = ?",
			[json_stats, item[0]])
		playerCur.execute(
			"UPDATE Guild_Bank SET StatBuffs = ? WHERE ItemId = ?",
			[json_stats, item[0]])
		playerCur.execute(
			"UPDATE Bag_Items SET StatBuffs = ? WHERE ItemId = ?",
			[json_stats, item[0]])
		playerCon.commit()
		print(" DONE ")
except sqlite3.Error as error:
	print("Error while processing :")
	print(error)
finally:
	gameCon.close()
	playerCon.close()

print("********* END OF MIGRATION *********")