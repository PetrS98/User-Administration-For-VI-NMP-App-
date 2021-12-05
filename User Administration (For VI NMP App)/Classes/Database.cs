using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public class Database
    {
        SqliteConnection sqliteConnection;

        public Database()
        {
            
        }

        //public bool CreateDatabase(string Path)
        //{
        //    if (Connect(Path) == false) return false;

        //    SqliteCommand sqliteCommand = sqliteConnection.CreateCommand();

        //    sqliteCommand.CommandText = "CREATE TABLE NexenUsers (ID integer primary key autoincrement, UserName text, Password text, Permission text);";

        //    try
        //    {
        //        sqliteCommand.ExecuteNonQuery();
        //    }
        //    catch 
        //    {
        //        sqliteConnection.Close();
        //        return false;
        //    }

        //    sqliteConnection.Close();
        //    return true;
        //}

        public List<string> ReadUserNames(string Path)
        {
            SqliteDataReader sqlReader;
            SqliteCommand sqliteCommand;

            List<string> UserNameList = new List<string>();

            if (Connect(Path) == false) return null;

            sqliteCommand = sqliteConnection.CreateCommand();
            sqliteCommand.CommandText = @"SELECT UserName FROM NexenUsers ;";

            try
            {
                sqlReader = sqliteCommand.ExecuteReader();
            }
            catch
            {
                sqliteConnection.Close();
                return null;
            }
            
            while (sqlReader.Read())
            {
                UserNameList.Add(sqlReader.GetString(0));
            }

            sqliteConnection.Close();
            return UserNameList;
        }

        public string[] ReadUserData(string Path, string UserName)
        {
            SqliteDataReader sqlReader;
            SqliteCommand sqliteCommand;

            string[] UserData = new string[3];

            if (Connect(Path) == false) return null;

            sqliteCommand = sqliteConnection.CreateCommand();
            sqliteCommand.CommandText = @"SELECT * FROM NexenUsers WHERE  UserName = $UserName;";

            sqliteCommand.Parameters.AddWithValue("$UserName", UserName);

            try
            {
                sqlReader = sqliteCommand.ExecuteReader();
            }
            catch
            {
                sqliteConnection.Close();
                return null;
            }

            for(int i = 0; i < UserData.Length; i++)
            {
                UserData[i] = sqlReader.GetString(i);
            }

            sqliteConnection.Close();
            return UserData;
        }

        public bool WriteData(string Path, string UserName, string Password, string Permission)
        {
            if (Connect(Path) == false) return false;

            SqliteCommand sqliteCommand = sqliteConnection.CreateCommand();

            sqliteCommand.CommandText = @"INSERT INTO NexenUsers (UserName,   Password,  Permission) 
                                                         VALUES ($UserName, $Password, $Permission)";

            sqliteCommand.Parameters.AddWithValue("$UserName", UserName);
            sqliteCommand.Parameters.AddWithValue("$Password", PasswordHasher.HashPassword(Password));
            sqliteCommand.Parameters.AddWithValue("$Permission", Permission);

            try
            {
                sqliteCommand.ExecuteNonQuery();
            }
            catch
            {
                sqliteConnection.Close();
                return false;
            }

            sqliteConnection.Close();
            return true;
        }

        public bool EditData(string Path, string UserName, string Password, string Permission, string OldUserName)
        {
            if (Connect(Path) == false) return false;

            SqliteCommand sqliteCommand = sqliteConnection.CreateCommand();

            sqliteCommand.CommandText = @"UPDATE NexenUsers SET UserName = $UserName, Password = $Password, Permission = $Permission WHERE UserName = $OldUserName";

            sqliteCommand.Parameters.AddWithValue("$UserName", UserName);
            sqliteCommand.Parameters.AddWithValue("$Password", PasswordHasher.HashPassword(Password));
            sqliteCommand.Parameters.AddWithValue("$Permission", Permission);
            sqliteCommand.Parameters.AddWithValue("$OldUserName", OldUserName);

            try
            {
                sqliteCommand.ExecuteNonQuery();
            }
            catch
            {
                sqliteConnection.Close();
                return false;
            }

            sqliteConnection.Close();
            return true;
        }

        public bool DeleteData(string Path, string UserName)
        {
            if (Connect(Path) == false) return false;

            SqliteCommand sqliteCommand = sqliteConnection.CreateCommand();

            sqliteCommand.CommandText = @"DELETE FROM NexenUsers WHERE UserName = $UserName;";

            sqliteCommand.Parameters.AddWithValue("$UserName", UserName);

            try
            {
                sqliteCommand.ExecuteNonQuery();
            }
            catch
            {
                sqliteConnection.Close();
                return false;
            }

            sqliteConnection.Close();
            return true;
        }

        private bool Connect(string Path)
        {
            try
            {
                sqliteConnection = new SqliteConnection("DataSource=" + Path + ".db");
                sqliteConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowPopup("Critical Error", ex.StackTrace);
                return false;
            }
        }
    }
}
