import json
import sqlite3


# This script will try to clean the useless columns in gamedata.db and playerdata.db
# It is possible to have compatibility issues with python sqlite3 module when using DROP COLUMN
# If it is the case, install sqlite3 latest version and try to DROP COLUMN using command line in the console


# /!\ LAUNCH AFTER RUNNING THE SERVER CONSOLE MIGRATION AT THE END OF ALL OTHERS MIGRATIONS TO CLEAN THE DATABASES /!\

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
	print("Connection to databases OK")

	print("Now deleting useless column StatGrowth ...")
	gameCur.execute("ALTER TABLE Items " +
					"DROP COLUMN StatGrowth")
	gameCon.commit()
	print("Column StatGrowth deleted successfully")
	print("Now deleting useless columns Effect_Percentage and Effect_Type ...")

	gameCur.execute("ALTER TABLE Items " +
					"DROP COLUMN Effect_Percentage")
	gameCur.execute("ALTER TABLE Items " +
					"DROP COLUMN Effect_Type")
	gameCon.commit()
	print("Columns deleted successfully")

	print("Now deleting useless columns on player database  ...")
	playerCur.execute("ALTER TABLE Player_Items DROP COLUMN StatBuffs")
	playerCur.execute("ALTER TABLE Player_Bank DROP COLUMN StatBuffs")
	playerCur.execute("ALTER TABLE Guild_Bank DROP COLUMN StatBuffs")
	playerCur.execute("ALTER TABLE Bag_Items DROP COLUMN StatBuffs")
	playerCur.execute("ALTER TABLE Player_Hotbar DROP COLUMN PreferredStatBuffs")
	playerCon.commit()
	print("Columns deleted successfully")
except sqlite3.Error as error:
	print("Error while deleting :")
	print(error)
	print("Try to delete columns manually using sqlite3 command line in the console")
finally:
	gameCon.close()

print("********* END OF MIGRATION *********")