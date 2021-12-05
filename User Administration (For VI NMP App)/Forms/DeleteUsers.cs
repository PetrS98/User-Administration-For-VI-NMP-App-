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
    public partial class DeleteUsers : Form
    {
        public DeleteUsers()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text =                          "Přidání Uživatele";
                lblTextDatabasePath.Text =      "Cesta k Databázi";
                btnBrowseDBPath.Text =          "Procházet";
                lblTextUserList.Text =          "Seznam Uživatelů";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text =                          "Add Users";
                lblTextDatabasePath.Text =      "Databaze Path";
                btnBrowseDBPath.Text =          "Browse";
                lblTextUserList.Text =          "Users List";
            }
        }
    }
}
