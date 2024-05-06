using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace PassengerTraffix
{

    class SQLiteInterface
    {
        public const string DATE_FORMAT = "yyyy/MM/dd";
        const string CONNECTION_STRING = "Data Source=database.db;Version=3;New=True;Compress=True;datetimeformat=CurrentCulture";
        private static SQLiteInterface database = new SQLiteInterface();
        SQLiteConnection connection;

        public static string[] TABLE_HEADERS_EN = 
            { "fullName", "nationalID", "phonenumber", "targetUnit", "closet", "vehicleModel", "plate", "date", "entrance", "exit" };
        public static string[] TABLE_HEADERS_FA = 
            { "نام", "کد ملی", "شماره تلفن", "واحد مراجعه", "کمد", "مدل خودرو", "پلاک", "تاریخ", "ورود", "خروج" };

        public static SQLiteInterface Database { get { return SQLiteInterface.database; } }

        public SQLiteCommand NewCommand(string text)
        {
            this.connection = new SQLiteConnection(CONNECTION_STRING);
            this.connection.Open();
            if (this.connection.State != ConnectionState.Open)
                throw new DatabaseOutOfReachException();
            SQLiteCommand cmd = new SQLiteCommand(text);
            cmd.Connection = this.connection;
            return cmd;
        }
        private void AlterOldTables()
        {
            try
            {
                // phone number and target unit columns:
                NewCommand("ALTER TABLE passengers ADD COLUMN closet INTEGER").ExecuteNonQuery();
                Console.WriteLine("closet column added to the old table.");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CreateTableIfNotExists() 
        {
            try
            {
                NewCommand("CREATE TABLE passengers(id INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "nationalID TEXT NOT NULL, phonenumber text, targetUnit text, closet INTEGER, " 
                    + "vehicleModel TEXT, fullName TEXT NOT NULL, "
                    + "plate TEXT, date DATE NOT NULL, entrance TIME, exit TIME)")
                    .ExecuteNonQuery();
                this.connection.Close();
                Console.WriteLine("Table created!");
            }
            catch (SQLiteException ex) 
            {
                Console.WriteLine(ex.Message);
                // make sure new fields (phonenumber and targetUnit) are added to the database.
                try
                {

                    AlterOldTables();
                }
                catch
                {
                    Console.WriteLine("Database has the latest structure.");
                }
            }

        }

        private SQLiteInterface()
        {
            try
            {
                this.CreateTableIfNotExists();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }

        public bool Update(Passenger passenger)
        {
            this.connection = new SQLiteConnection(CONNECTION_STRING);
            this.connection.Open();
            if (this.connection.State != ConnectionState.Open)
                throw new DatabaseOutOfReachException();
            int result = 0;
            Console.WriteLine(passenger.Id.ToString(), passenger.Entering);
            if (passenger.Entering || passenger.Id <= 0)
            {
                Console.WriteLine("INSERT");
                result = NewCommand("INSERT INTO `passengers` " +
                    string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", TABLE_HEADERS_EN[0], TABLE_HEADERS_EN[1], TABLE_HEADERS_EN[2],
                        TABLE_HEADERS_EN[3], TABLE_HEADERS_EN[4], TABLE_HEADERS_EN[5], TABLE_HEADERS_EN[6], TABLE_HEADERS_EN[7], passenger.Entering ? TABLE_HEADERS_EN[8] : TABLE_HEADERS_EN[9]) +
                    string.Format(" VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}')",
                        passenger.Fullname, passenger.NationalID, passenger.Phonenumber, passenger.TargetUnit, passenger.ClosetNumber,
                        passenger.VehicleModel, passenger.Plate?.ToString(), passenger.Date.ToStringFormat("yyyy/MM/dd"), passenger.Time))
                    .ExecuteNonQuery();
                passenger.Id = this.GetLastInertedId();
            }
            else
            {
                Console.WriteLine("UPDATE");
                result = NewCommand("UPDATE `passengers` SET " +
                    string.Format("{1}='{9}',{2}='{10}',{3}='{11}',{4}='{12}',{5}={13},{6}='{14}',{7}='{15}',{8}='{16}' WHERE id={0}", 
                        passenger.Id, TABLE_HEADERS_EN[0], TABLE_HEADERS_EN[1], TABLE_HEADERS_EN[2],
                        TABLE_HEADERS_EN[3], TABLE_HEADERS_EN[4], TABLE_HEADERS_EN[5], TABLE_HEADERS_EN[6], TABLE_HEADERS_EN[9],
                        passenger.Fullname, passenger.NationalID, passenger.Phonenumber, passenger.TargetUnit, passenger.ClosetNumber,
                        passenger.VehicleModel, passenger.Plate?.ToString(), passenger.Time))
                    .ExecuteNonQuery();
            }
            this.connection.Close();
            return result == 1 ? true : false;
        }

        public DataTable Fetch()
        {
            SQLiteCommand cmd = NewCommand(
                string.Format("SELECT {0}, {1}, {2}, {3}, {4}, {5}, {6}, cast({7} as TEXT) as {7}, TIME({8}) AS {8}," +
                    " TIME({9}) AS {9} FROM `passengers`;", TABLE_HEADERS_EN[0], TABLE_HEADERS_EN[1], TABLE_HEADERS_EN[2],
                        TABLE_HEADERS_EN[3], TABLE_HEADERS_EN[4], TABLE_HEADERS_EN[5], TABLE_HEADERS_EN[6], 
                        TABLE_HEADERS_EN[7], TABLE_HEADERS_EN[8], TABLE_HEADERS_EN[9]));

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                DataTable result = new DataTable();
                adapter.Fill(result);
                this.connection.Close();

                return result;
            }

        }
        public long GetLastInertedId()
        {

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM `passengers` ORDER BY id DESC LIMIT 1;", this.connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        return reader.GetInt64(0);
                    }
                }
            }
            return 0;
        }

        public void Save(DataTable newData)
        {
            NewCommand(string.Format("DELETE FROM {0}", newData.TableName)).ExecuteNonQuery();
            SQLiteCommand cmd = NewCommand(string.Format("SELECT * from {0}", newData.TableName));
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, this.connection))
            {
                adapter.Update(newData);
            }
            this.connection.Close();

        }
    }
}
