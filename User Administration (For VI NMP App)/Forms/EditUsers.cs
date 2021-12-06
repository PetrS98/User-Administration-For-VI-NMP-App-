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
        MySQLDatabase mySQLDatabase;

        public EditUsers(MySQLDatabase MySQLDatabase)
        {
            InitializeComponent();

            mySQLDatabase = MySQLDatabase;

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text =                          "Smazání Uživatele";
                lblTextUserList.Text =          "Seznam Uživatelů";
                lblTextUserName.Text =          "Uživatelské Jméno";
                lblTextPassword.Text =          "Heslo";
                lblTextConfirmPassword.Text =   "Potvrzení Hesla";
                btnClearParameters.Text =       "Vyčistit Parametry";
                btnSaveUser.Text =              "Přidat do Databáze";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text =                          "Delete Users";
                lblTextUserList.Text =          "Users List";
                lblTextUserName.Text =          "User Name";
                lblTextPassword.Text =          "Password";
                lblTextConfirmPassword.Text =   "Confirm Password";
                btnClearParameters.Text =       "Clear Parameters";
                btnSaveUser.Text =              "Add to Database";
            }
        }
    }
}
