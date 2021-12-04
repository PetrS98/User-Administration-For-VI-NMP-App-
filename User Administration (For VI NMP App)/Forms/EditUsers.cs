using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text =                          "Smazání Uživatele";
                lblTextDatabasePath.Text =      "Cesta k Databázi";
                btnBrowseDBPath.Text =          "Procházet";
                lblTextUserList.Text =          "Seznam Uživatelů";
                lblTextUserName.Text =          "Uživatelské Jméno";
                lblTextPassword.Text =          "Heslo";
                lblTextConfirmPassword.Text =   "Potvrzení Hesla";
                lblTextPermissionsList.Text =   "Seznam Opravnění";
                lblTextUserPermissions.Text =   "Oprávnění Uživatele";
                btnClearParameters.Text =       "Vyčistit Parametry";
                btnSaveUser.Text =              "Přidat do Databáze";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text =                          "Delete Users";
                lblTextDatabasePath.Text =      "Databaze Path";
                btnBrowseDBPath.Text =          "Browse";
                lblTextUserList.Text =          "Users List";
                lblTextUserName.Text =          "User Name";
                lblTextPassword.Text =          "Password";
                lblTextConfirmPassword.Text =   "Confirm Password";
                lblTextPermissionsList.Text =   "Permissions List";
                lblTextUserPermissions.Text =   "User Permissions";
                btnClearParameters.Text =       "Clear Parameters";
                btnSaveUser.Text =              "Add to Database";
            }
        }

        private void EditUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
