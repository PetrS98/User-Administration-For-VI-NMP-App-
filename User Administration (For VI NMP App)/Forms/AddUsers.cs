using System;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;
using VisualInspection.Utils.Net;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class AddUsers : Form
    {
        MySQLDatabase mySQLDatabase;

        string ErrorTitle;
        private string[] Errors = new string[6];

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
                //*****************************Errory*********************************
                //-------------------------------------------------------------------

                ErrorTitle = "Chyba Uživatelského Vstupu";
                Errors[0] = "Osobní číslo musí být číslo!!!";
                Errors[1] = "Jméno může obsahovat pouze písmena. např. Jan, Jana";
                Errors[2] = "Příjmení může obsahovat pouze písmena. např. Novák, Nováková";
                Errors[3] = "Heslo musí být zadané!!!";
                Errors[4] = "Heslo se musí shodovat s ověřovacím heslem!!!";
                Errors[5] = "Oprávnění uživatele musí být vyplněné!!!";

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

                ErrorTitle = "User Input Error";
                Errors[0] = "Personal number must be number!!!";
                Errors[1] = "First name must contain only letters. e.g. John, Jane";
                Errors[2] = "Last name must contain only letters. e.g. Doe";
                Errors[3] = "Password must not be empty!!!";
                Errors[4] = "Password and confirm password must be same!!!";
                Errors[5] = "User permission must not be empty!!!";

            }
        }

        private void AddUsers_VisibleChanged(object sender, EventArgs e)
        {
            LoadPermissions();
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

        private void btnClearParameters_Click(object sender, EventArgs e)
        {
            ClearParam();
            perPick.Reset();
            LoadPermissions();
        }

        private void LoadPermissions()
        {
            if (Visible && mySQLDatabase.Status == ClientStatus.Connected) perPick.InitializePermissions(mySQLDatabase.ReadPermissionList());
        }

        private bool CheckInputInfo()
        {
            if (TextBoxHelper.TbInputIsNumber(tbPersonalID) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[0]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbFirstName) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[1]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbLastName) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[2]);
                return false;
            }
            if (tbPassword.Text == null || tbPassword.Text == "")
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[3]);
                return false;
            }
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[4]);
                return false;
            }
            if (perPick.GetPickedPermissions().Count == 0)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[5]);
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
    }
}
