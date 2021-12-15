using System;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;

namespace User_Administration__For_VI_NMP_App_.Classes
{
    public partial class ConnectToDatabase : Form
    {
        MySQLDatabase mySQLDatabase;

        private string InputErrorTitle;
        private string[] Errors = new string[2];

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

                InputErrorTitle =    "Chyba Vstupu";
                Errors[0] =     "Ip adresa není ve správném tvaru. (např. 192.168.110.120)";
                Errors[1] =     "Uživatelské jméno nesmí být prázdné!!!";

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

                InputErrorTitle =    "Input Error";
                Errors[0] =     "Ip address is not in correct format. (e.g 192.168.110.120)";
                Errors[1] =     "User name must not be empty!!!";

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CheckInputInfo() == false) return;

            if (mySQLDatabase.ConnectToDB(iabServerIp.IPAddress, tbUserName.Text, tbPassword.Text))
            {
                SetEnableControls(false);
                tbPassword.Text = "";
            } 
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            mySQLDatabase.DisconnectFromDB();

            SetEnableControls(true);
            tbUserName.Text = "";
        }

        private bool CheckInputInfo()
        {
            if (iabServerIp.IPAddressValid == false)
            {
                iabServerIp.Blink();
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[0]);
                return false;
            }

            if (tbUserName.Text == null || tbUserName.Text == "")
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[1]);
                return false;
            }

            return true;
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
