using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;
using VisualInspection.Utils.Net;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class AddUsers : Form
    {
        MySQLDatabase mySQLDatabase;

        private string[] Error_1 = new string[2];
        private string[] Error_2 = new string[2];
        private string[] Error_3 = new string[2];
        private string[] Error_4 = new string[2];
        private string[] Error_5 = new string[2];
        private string[] Error_6 = new string[2];

        public AddUsers(MySQLDatabase MySQLDatabase)
        {
            InitializeComponent();

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

                lblTextPersonalID.Text =            "Osobní Číslo";
                lblTextFirstName.Text =             "Jméno";
                lblTextLastName.Text =              "Příjmení";
                lblTextPassword.Text =              "Heslo";
                lblTextConfirmPassword.Text =       "Potvrzení Hesla";
                btnClearParameters.Text =           "Vyčistit Parametry";
                btnAddToDatabase.Text =             "Přidat do Databáze";

                //-------------------------------------------------------------------
                //*****************************Erory*********************************
                //-------------------------------------------------------------------

                Error_1[0] = "Chyba Uživatelsého Vstupu";
                Error_1[1] = "Osobní číslo musí být číslo!!!";
                Error_2[0] = "Chyba Uživatelsého Vstupu";
                Error_2[1] = "Jméno může obsahovat pouze písmena. např. Jan, Jana";
                Error_3[0] = "Chyba Uživatelsého Vstupu";
                Error_3[1] = "Příjmení může obsahovat pouze písmena. např. Novák, Nováková";
                Error_4[0] = "Chyba Uživatelsého Vstupu";
                Error_4[1] = "Heslo musí být zadané!!!";
                Error_5[0] = "Chyba Uživatelsého Vstupu";
                Error_5[1] = "Heslo se musí shodovat s ověřovacím heslem!!!";
                Error_6[0] = "Chyba Uživatelsého Vstupu";
                Error_6[1] = "Oprávnění uživatele musí být vyplněné!!!";

            }
            else if (Translator.Language == Language.ENG)
            {
                //-------------------------------------------------------------------
                //***************************Form Texts******************************
                //-------------------------------------------------------------------

                lblTextPersonalID.Text =            "Personal ID";
                lblTextFirstName.Text =             "First Name";
                lblTextLastName.Text =              "Last Name";
                lblTextPassword.Text =              "Password";
                lblTextConfirmPassword.Text =       "Confirm Password";
                btnClearParameters.Text =           "Clear Parameters";
                btnAddToDatabase.Text =             "Add to Database";

                //-------------------------------------------------------------------
                //*****************************Errors********************************
                //-------------------------------------------------------------------

                Error_1[0] = "User Input Error";
                Error_1[1] = "Personal number must be number!!!";
                Error_2[0] = "User Input Error";
                Error_2[1] = "First name must contain only letters. e.g. John, Jane";
                Error_3[0] = "User Input Error";
                Error_3[1] = "Last name must contain only letters. e.g. Doe";
                Error_4[0] = "User Input Error";
                Error_4[1] = "Password must not be empty!!!";
                Error_5[0] = "User Input Error";
                Error_5[1] = "Password and confirm password must be same!!!";
                Error_6[0] = "User Input Error";
                Error_6[1] = "User permission must not be empty!!!";

            }
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            if (CheckInputInfo() == false) return;

            UserNameAndID userNameAndID = new UserNameAndID(int.Parse(tbPersonalID.Text), tbFirstName.Text, tbLastName.Text);
            string password = PasswordHasher.HashPassword(tbPassword.Text);

            UserInformations userInformations = new UserInformations(userNameAndID, password, perPick.GetPickedPermissions());

            if (mySQLDatabase.AddUserToDB(userInformations) == false) return;

            ClearParam();
            perPick.Reset();
            LoadPermissions();
        }

        private bool CheckInputInfo()
        {
            if(TextBoxHelper.TbInputIsNumber(tbPersonalID) == false)
            {
                CustomMessageBox.ShowPopup(Error_1[0], Error_1[1]);
                return false;
            }
            if(TextBoxHelper.TbInputIsText(tbFirstName) == false)
            {
                CustomMessageBox.ShowPopup(Error_2[0], Error_2[1]);
                return false;
            }
            if(TextBoxHelper.TbInputIsText(tbLastName) == false)
            {
                CustomMessageBox.ShowPopup(Error_3[0], Error_3[1]);
                return false;
            }
            if(tbPassword.Text == null || tbPassword.Text == "")
            {
                CustomMessageBox.ShowPopup(Error_4[0], Error_4[1]);
                return false;
            }
            if(tbPassword.Text != tbConfirmPassword.Text)
            {
                CustomMessageBox.ShowPopup(Error_5[0], Error_5[1]);
                return false;
            }
            if(perPick.GetPickedPermissions().Count == 0)
            {
                CustomMessageBox.ShowPopup(Error_6[0], Error_6[1]);
                return false;
            }
            return true;
        }

        private void ClearParam()
        {
            tbPersonalID.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
        }

        private void LoadPermissions()
        {
            if (Visible && mySQLDatabase.Status == ClientStatus.Connected) perPick.InitializePermissions(mySQLDatabase.ReadPermissionList());
        }

        private void AddUsers_VisibleChanged(object sender, EventArgs e)
        {
            LoadPermissions();
        }

        private void btnClearParameters_Click(object sender, EventArgs e)
        {
            ClearParam();
            perPick.Reset();
            LoadPermissions();
        }
    }
}
