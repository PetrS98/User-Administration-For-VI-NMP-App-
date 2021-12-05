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
        MySQLDatabase mySQLDatabase;

        public DeleteUsers(MySQLDatabase MySQLDatabase)
        {
            InitializeComponent();

            mySQLDatabase = MySQLDatabase;

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                lblTextUserList.Text =          "Seznam Uživatelů";
                btnDelete.Text =                "Smazat";
            }
            else if (Translator.Language == Language.ENG)
            {
                lblTextUserList.Text =          "Users List";
                btnDelete.Text =                "Delete";
            }
        }
    }
}
