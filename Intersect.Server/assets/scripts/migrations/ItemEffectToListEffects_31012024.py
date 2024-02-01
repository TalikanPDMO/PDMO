import sqlite3

# Convert all the extrat effects in Items into a list of extra effects, with minimum and maximum range
# Then, remove the useless old fields for extra effects

# /!\ LAUNCH JUST AFTER RUNNING THE SERVER CONSOLE MIGRATION /!\

# Always SHUTDOWN THE SERVER when running migrations scripts


gamedata_path = "/home/resources/gamedata.db"

print("********* START OF MIGRATION *********")
try:
	# existing DB
	gameCon = sqlite3.connect(gamedata_path)
	gameCur = gameCon.cursor()
	print("Connection to database OK")

	gameCur.execute("UPDATE Items " +
	                "SET Effects = '[{\"Type\":' || Effect_Type || ',\"Min\":' || Effect_Percentage || ',\"Max\":' || Effect_Percentage || '}]' " +
					"WHERE Effect_Type > 0")
	gameCon.commit()

	print("Items Extra effects converted sucessfully")
	print("Now deleting useless columns Effect_Percentage and Effect_Type ...")

	gameCur.execute("ALTER TABLE Items " +
					"DROP COLUMN Effect_Percentage")
	gameCur.execute("ALTER TABLE Items " +
					"DROP COLUMN Effect_Type")
	gameCon.commit()
	print("Columns deleted succesfully")
except sqlite3.Error as error:
	print("Error while processing :")
	print(error)
finally:
	gameCon.close()

print("********* END OF MIGRATION *********")
