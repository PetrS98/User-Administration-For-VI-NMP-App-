using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms;
using VisualInspection.Utils.Net;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class EditUsers : Form
    {
        MySQLDatabase mySQLDatabase;
        UserInformations UserInformations = new UserInformations(null, null, null);

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
                lblTextPersonalID.Text =        "Osobní Číslo";
                lblTextFirstName.Text =         "Jméno";
                lblTextLastName.Text =          "Příjmení";
                lblTextPassword.Text =          "Heslo";
                lblTextConfirmPassword.Text =   "Potvrzení Hesla";
                btnClearParameters.Text =       "Vyčistit Parametry";
                btnSaveUser.Text =              "Přidat do Databáze";
            }
            else if (Translator.Language == Language.ENG)
            {
                lblTextPersonalID.Text =        "Personal ID";
                lblTextFirstName.Text =         "First Name";
                lblTextLastName.Text =          "Last Name";
                lblTextPassword.Text =          "Password";
                lblTextConfirmPassword.Text =   "Confirm Password";
                btnClearParameters.Text =       "Clear Parameters";
                btnSaveUser.Text =              "Add to Database";
            }
        }

        private void EditUsers_VisibleChanged(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbUsersList.SelectedIndex = lbUsersList.FindString(tbSearchUser.Text);
        }

        private void btnClearParameters_Click(object sender, EventArgs e)
        {
            
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
    }
}
