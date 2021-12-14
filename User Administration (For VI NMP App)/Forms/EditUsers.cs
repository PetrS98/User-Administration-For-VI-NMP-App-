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
    public partial class EditUsers : Form
    {
        MySQLDatabase mySQLDatabase;
        UserInformations UserInformations;
        UserInformations OldUserInformations;

        private string[] Error_1 = new string[2];
        private string[] Error_2 = new string[2];
        private string[] Error_3 = new string[2];
        private string[] Error_4 = new string[2];
        private string[] Error_5 = new string[2];
        private string[] Error_6 = new string[2];

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

                lblTextPersonalID.Text =        "Osobní Číslo";
                lblTextFirstName.Text =         "Jméno";
                lblTextLastName.Text =          "Příjmení";
                lblTextPassword.Text =          "Heslo";
                lblTextConfirmPassword.Text =   "Potvrzení Hesla";
                btnClearParameters.Text =       "Vyčistit Parametry";
                btnSaveUser.Text =              "Přidat do Databáze";

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

                lblTextPersonalID.Text =        "Personal ID";
                lblTextFirstName.Text =         "First Name";
                lblTextLastName.Text =          "Last Name";
                lblTextPassword.Text =          "Password";
                lblTextConfirmPassword.Text =   "Confirm Password";
                btnClearParameters.Text =       "Clear Parameters";
                btnSaveUser.Text =              "Add to Database";

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

        private void LoadUsersAndPermissions()
        {
            if (Visible && mySQLDatabase.Status == ClientStatus.Connected)
            {
                lbUsersList.Items.Clear();

                perPick.InitializePermissions(mySQLDatabase.ReadPermission());

                foreach (var UserName in mySQLDatabase.ReadAllNamesAndIDs())
                {
                    lbUsersList.Items.Add(UserName.ID.ToString() + " | " + UserName.FirstName + " " + UserName.LastName);
                }
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (CheckInputInfo())
            {
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
        }

        private bool CheckInputInfo()
        {
            if (TbInputIsNumber(tbPersonalID) == false)
            {
                CustomMessageBox.ShowPopup(Error_1[0], Error_1[1]);
                return false;
            }
            if (TbInputIsText(tbFirstName) == false)
            {
                CustomMessageBox.ShowPopup(Error_2[0], Error_2[1]);
                return false;
            }
            if (TbInputIsText(tbLastName) == false)
            {
                CustomMessageBox.ShowPopup(Error_3[0], Error_3[1]);
                return false;
            }
            if (rdbNewPassword.Checked)
            {
                if (tbPassword.Text == null || tbPassword.Text == "")
                {
                    CustomMessageBox.ShowPopup(Error_4[0], Error_4[1]);
                    return false;
                }
                if (tbPassword.Text != tbConfirmPassword.Text)
                {
                    CustomMessageBox.ShowPopup(Error_5[0], Error_5[1]);
                    return false;
                }
            }
            if (perPick.GetPickedPermissions().Count == 0)
            {
                CustomMessageBox.ShowPopup(Error_6[0], Error_6[1]);
                return false;
            }
            return true;
        }

        private bool TbInputIsNumber(TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int result);
        }

        private bool TbInputIsText(TextBox textBox)
        {
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (IsLetter(textBox.Text[i])) continue;
                return false;
            }

            if (textBox.Text == null || textBox.Text == "")
            {
                return false;
            }

            return true;
        }

        private bool IsLetter(char c)
        {
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzĚŠČŘŽÝÁÍÉÚŮÓěščřžýáíéúůóß".IndexOf(c) != -1;
        }
    }
}
