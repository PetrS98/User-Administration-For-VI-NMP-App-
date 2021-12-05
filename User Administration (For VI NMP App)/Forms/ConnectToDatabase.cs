using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public partial class ConnectToDatabase : Form
    {
        MySQLDatabase mySQLDatabase;

        string[] Error_1 = new string[2];
        string[] Error_2 = new string[2];
        string[] Error_3 = new string[2];

        public ConnectToDatabase(MySQLDatabase MySQLDatabase)
        {
            InitializeComponent();
            SetEnableControls(true);

            mySQLDatabase = MySQLDatabase;

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                //-------------------------------------------------------------------
                //*************************Texty Obrazovky***************************
                //-------------------------------------------------------------------

                lblTextIpAddress.Text =         "IP Adresa Serveru";
                lblTextUserName.Text =          "Uživatelské Jméno";
                lblTextPassword.Text =          "Heslo";
                lblTextConnectionStatus.Text =  "Status Připojení";
                btnConnect.Text =               "Připojit";
                btnDisconnect.Text =            "Odpojit";

                //-------------------------------------------------------------------
                //*****************************Erory*********************************
                //-------------------------------------------------------------------

                Error_1[0] =    "Chyba Vstupu";
                Error_1[1] =    "Ip adresa není ve správném tvaru. (např. 192.168.110.120)";
                Error_2[0] =    "Chyba Vstupu";
                Error_2[1] =    "Uživatelské jméno nesmí být prázdné!!!";
                Error_3[0] =    "Chyba Vstupu";
                Error_3[1] =    "Heslo nesmí být prázdné!!!";

            }
            else if (Translator.Language == Language.ENG)
            {
                //-------------------------------------------------------------------
                //***************************Form Texts******************************
                //-------------------------------------------------------------------

                lblTextIpAddress.Text =         "Server IP Address";
                lblTextUserName.Text =          "User Name";
                lblTextPassword.Text =          "Password";
                lblTextConnectionStatus.Text =  "Connection Status";
                btnConnect.Text =               "Connect";
                btnDisconnect.Text =            "Disconnect";

                //-------------------------------------------------------------------
                //*****************************Errors********************************
                //-------------------------------------------------------------------

                Error_1[0] =    "Input Error";
                Error_1[1] =    "Ip address is not in correct format. (e.g 192.168.110.120)";
                Error_2[0] =    "Input Error";
                Error_2[1] =    "User name must not be empty!!!";
                Error_3[0] =    "Input Error";
                Error_3[1] =    "Password must not be empty!!!";

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(iabServerIp.IPAddressValid == false)
            {
                iabServerIp.Blink();
                CustomMessageBox.ShowPopup(Error_1[0], Error_1[1]);
                return;
            }

            if(tbUserName.Text == null || tbUserName.Text == "")
            {
                CustomMessageBox.ShowPopup(Error_2[0], Error_2[1]);
                return;
            }

            if(mySQLDatabase.ConnectToDatabase(iabServerIp.IPAddress, tbUserName.Text, tbPassword.Text))
            {
                SetEnableControls(false);
                tbPassword.Text = "";
            } 
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            mySQLDatabase.DisconnectFromDatabase();

            SetEnableControls(true);
            tbUserName.Text = "";
        }

        private void SetEnableControls(bool Enable)
        {
            iabServerIp.Enabled = Enable;
            tbUserName.Enabled = Enable;
            tbPassword.Enabled = Enable;
            btnConnect.Enabled = Enable;
            btnDisconnect.Enabled = !Enable;
        }
    }
}
