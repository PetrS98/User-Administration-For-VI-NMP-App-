using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Timers;
using MySqlConnector;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;
using VisualInspection.Utils.Net;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public class MySQLDatabase : IHasClientStatus
    {
        private MySqlConnection mySqlConnection;

        private Timer _timerStatus = new Timer();

        private ClientStatus status = ClientStatus.Disconnected;
        public ClientStatus Status
        {
            get { return status; }
            private set
            {
                status = value;
                StatusChanged?.Invoke(this, value);
            }
        }

        public event EventHandler<ClientStatus> StatusChanged;

        public MySQLDatabase()
        {
            _timerStatus.Interval = 100;
            _timerStatus.Elapsed += CheckStatus;
            _timerStatus.Start();
        }

        public bool ConnectToDatabase(string IpAddress, string UserName, string Password)
        {
            try
            {
                mySqlConnection = new MySqlConnection("server=" + IpAddress + ";" + "uid=" + UserName + ";" + "pwd=" + Password + ";" + "database=db_visual_inspection");
                mySqlConnection.Open();
                return true;
            }
            catch(Exception ex)
            {
                CustomMessageBox.ShowPopup("Alarm", ex.ToString());
                return false;
            }
        }

        public void DisconnectFromDatabase()
        {
            mySqlConnection.Close();
        }

        public List<Permission> ReadPermission()
        {
            MySqlDataReader mySqlDataReader;
            MySqlCommand mySqlCommand = new MySqlCommand();

            List<Permission> UserPermission = new List<Permission>();

            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.CommandText = @"SELECT permission_name, bit_position FROM permissions;";

            try
            {
                mySqlDataReader = mySqlCommand.ExecuteReader();
            }
            catch
            {
                return null;
            }

            while (mySqlDataReader.Read())
            {
                Permission permission = new Permission(mySqlDataReader.GetString(0), mySqlDataReader.GetByte(1));

                UserPermission.Add(permission);
            }

            return UserPermission;
        }

        private void CheckStatus(object sender, ElapsedEventArgs e)
        {
            if (mySqlConnection is null) return;
            var state = mySqlConnection.State;

            if (state == ConnectionState.Open)
            {
                Status = ClientStatus.Connected;
            }
            else if (state == ConnectionState.Connecting)
            {
                Status = ClientStatus.Connecting;
            }
            else
            {
                Status = ClientStatus.Disconnected;
            }
        }
    }
}
