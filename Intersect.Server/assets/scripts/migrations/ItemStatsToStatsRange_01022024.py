import json
import sqlite3

# Convert the stats of all items into the new format with min/max stats

gamedata_path = "/home/resources/gamedata.db"
playerdata_path = "/home/resources/playerdata.db"

print("********* START OF MIGRATION *********")
try:
	# existing DB
	gameCon = sqlite3.connect(gamedata_path)
	gameCur = gameCon.cursor()
	print("Connection to database OK")

	gameCur.execute("SELECT Id, Name, StatsGiven, StatGrowth  FROM Items ")
	items = gameCur.fetchall()
	print(len(items), " items detected")
	print("Now updating items ...")
	for item in items:
		current_stats = json.loads(item[2])
		stats_given = []
		for s in current_stats:
			stats_given.append([s-item[3], s+item[3]])
		gameCur.execute("UPDATE Items SET StatsGiven = ? WHERE Id = ?", [json.dumps(stats_given), item[0]])
	gameCon.commit()
	print("All the items were successfully updated")
	print("Now deleting useless column StatGrowth ...")
	gameCur.execute("ALTER TABLE Items " +
					"DROP COLUMN StatGrowth")
	gameCon.commit()
	print("Column deleted successfully")
except sqlite3.Error as error:
	print("Error while processing :")
	print(error)
finally:
	gameCon.close()

print("********* END OF MIGRATION *********")
