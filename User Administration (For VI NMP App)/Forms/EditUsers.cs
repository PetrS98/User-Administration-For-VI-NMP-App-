using System;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;
using VisualInspection.Utils.Net;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class EditUsers : Form
    {
        MySQLDatabase mySQLDatabase;
        UserInformations UserInformations;
        UserInformations OldUserInformations;

        private string InputErrorTitle;
        private string ErrorTitle;
        private string[] Errors = new string[7];

        public EditUsers(MySQLDatabase MySQLDatabase)
        {
            InitializeComponent();

            mySQLDatabase = MySQLDatabase;

            Translator.LanguageChanged += Translate;

            EnablePassword(false);
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                //-------------------------------------------------------------------
                //*************************Texty Obrazovky***************************
                //-------------------------------------------------------------------

                lblTextUserList.Text =          "Seznam Uživatelů";
                lblTextPersonalID.Text =        "Osobní Číslo";
                lblTextFirstName.Text =         "Jméno";
                lblTextLastName.Text =          "Příjmení";
                rdbNewPassword.Text =           "Nové Heslo";
                rdbOldPassword.Text =           "Staré Heslo";
                lblTextPassword.Text =          "Heslo";
                lblTextConfirmPassword.Text =   "Potvrzení Hesla";
                btnClearParameters.Text =       "Vyčistit Parametry";
                btnSaveUser.Text =              "Přidat do Databáze";

                //-------------------------------------------------------------------
                //*****************************Erory*********************************
                //-------------------------------------------------------------------

                InputErrorTitle = "Chyba Uživatelsého Vstupu";
                ErrorTitle = "Chyba";
                Errors[0] = "Osobní číslo musí být číslo!!!";
                Errors[1] = "Jméno může obsahovat pouze písmena. např. Jan, Jana";
                Errors[2] = "Příjmení může obsahovat pouze písmena. např. Novák, Nováková";
                Errors[3] = "Heslo musí být zadané!!!";
                Errors[4] = "Heslo se musí shodovat s ověřovacím heslem!!!";
                Errors[5] = "Oprávnění uživatele musí být vyplněné!!!";
                Errors[6] = "Osobní číslo nemá správný formát.";

            }
            else if (Translator.Language == Language.ENG)
            {
                //-------------------------------------------------------------------
                //***************************Form Texts******************************
                //-------------------------------------------------------------------

                lblTextUserList.Text =          "Users List";
                lblTextPersonalID.Text =        "Personal ID";
                lblTextFirstName.Text =         "First Name";
                lblTextLastName.Text =          "Last Name";
                rdbNewPassword.Text =           "New Password";
                rdbOldPassword.Text =           "Old Password";
                lblTextPassword.Text =          "Password";
                lblTextConfirmPassword.Text =   "Confirm Password";
                btnClearParameters.Text =       "Clear Parameters";
                btnSaveUser.Text =              "Add to Database";

                //-------------------------------------------------------------------
                //*****************************Errors********************************
                //-------------------------------------------------------------------

                InputErrorTitle = "User Input Error";
                ErrorTitle = "Error";
                Errors[0] = "Personal number must be number!!!";
                Errors[1] = "First name must contain only letters. e.g. John, Jane";
                Errors[2] = "Last name must contain only letters. e.g. Doe";
                Errors[3] = "Password must not be empty!!!";
                Errors[4] = "Password and confirm password must be same!!!";
                Errors[5] = "User permission must not be empty!!!";
                Errors[6] = "Personal ID is in a wrong format.";
            }
        }

        private void EditUsers_VisibleChanged(object sender, EventArgs e)
        {
            LoadUsersAndPermissions();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbUsersList.SelectedIndex = lbUsersList.FindString(tbSearchUser.Text);
        }

        private void btnClearParameters_Click(object sender, EventArgs e)
        {
            LoadUsersAndPermissions();
            ClearParam();
            perPick.Reset();
        }

        private void lbUsersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbUsersList.SelectedItem == null || lbUsersList.SelectedItem.ToString() == "") return;

            EnablePassword(false);

            string[] IDAndName = lbUsersList.SelectedItem.ToString().Split(" | ");

            if (StringHelper.CheckIfTextIsNumber(IDAndName[0]) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[6]);
                return;
            }

            UserInformations = mySQLDatabase.ReadUserInformation(int.Parse(IDAndName[0]));

            tbPersonalID.Text = UserInformations.NameAndID.ID.ToString();
            tbFirstName.Text = UserInformations.NameAndID.FirstName;
            tbLastName.Text = UserInformations.NameAndID.LastName;

            perPick.LoadPermissions(UserInformations.Permission);

            OldUserInformations = UserInformations;
        }

        private void rbdPasswordSel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNewPassword.Checked == false && rdbOldPassword.Checked) EnablePassword(false);
            else EnablePassword(true);
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (CheckInputInfo() == false) return;

            UserNameAndID userNameAndID = new UserNameAndID(int.Parse(tbPersonalID.Text), tbFirstName.Text, tbLastName.Text);
            string password;

            if (rdbNewPassword.Checked)
            {
                password = PasswordHasher.HashPassword(tbPassword.Text);
            }
            else
            {
                password = OldUserInformations.Password;
            }

            UserInformations = new UserInformations(userNameAndID, password, perPick.GetPickedPermissions());

            mySQLDatabase.UpdateUserInformations(UserInformations, OldUserInformations);

            LoadUsersAndPermissions();
            ClearParam();
            perPick.Reset();
        }

        private void LoadUsersAndPermissions()
        {
            if (Visible && mySQLDatabase.Status == ClientStatus.Connected)
            {
                lbUsersList.Items.Clear();

                perPick.InitializePermissions(mySQLDatabase.ReadPermissionList());

                foreach (var UserName in mySQLDatabase.ReadNamesAndIDs())
                {
                    lbUsersList.Items.Add(UserName.ID.ToString() + " | " + UserName.FirstName + " " + UserName.LastName);
                }
            }
        }

        private bool CheckInputInfo()
        {
            if (TextBoxHelper.TbInputIsNumber(tbPersonalID) == false)
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[0]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbFirstName) == false)
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[1]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbLastName) == false)
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[2]);
                return false;
            }
            if (rdbNewPassword.Checked)
            {
                if (tbPassword.Text == null || tbPassword.Text == "")
                {
                    CustomMessageBox.ShowPopup(InputErrorTitle, Errors[3]);
                    return false;
                }
                if (tbPassword.Text != tbConfirmPassword.Text)
                {
                    CustomMessageBox.ShowPopup(InputErrorTitle, Errors[4]);
                    return false;
                }
            }
            if (perPick.GetPickedPermissions().Count == 0)
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[5]);
                return false;
            }
            return true;
        }

        private void EnablePassword(bool Enable)
        {
            tbPassword.ReadOnly = !Enable;
            tbConfirmPassword.ReadOnly = !Enable;

            if (Enable)
            {
                tbPassword.Cursor = Cursors.IBeam;
                tbConfirmPassword.Cursor = Cursors.IBeam;
            }
            else
            {
                tbPassword.Cursor = Cursors.No;
                tbConfirmPassword.Cursor = Cursors.No;
            }
        }

        private void ClearParam()
        {
            tbPersonalID.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            rdbOldPassword.Checked = true;
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            UserInformations = null;
            OldUserInformations = null;
        }
    }
}
