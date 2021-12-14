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

        private void LoadUsers()
        {
            if (Visible && mySQLDatabase.Status == ClientStatus.Connected)
            {
                lbUsersList.Items.Clear();

                foreach (var UserName in mySQLDatabase.ReadNamesAndIDs())
                {
                    lbUsersList.Items.Add(UserName.ID.ToString() + " | " + UserName.FirstName + " " + UserName.LastName);
                }
            }
        }

        private void DeleteUsers_VisibleChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbUsersList.SelectedItem == null || lbUsersList.SelectedItem.ToString() == "") return;

            string[] IDAndName = lbUsersList.SelectedItem.ToString().Split(" | ");

            if (mySQLDatabase.DeleteUserFromDB(int.Parse(IDAndName[0]))) LoadUsers();
        }
    }
}
