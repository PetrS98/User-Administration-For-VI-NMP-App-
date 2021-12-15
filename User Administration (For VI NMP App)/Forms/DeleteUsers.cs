using System;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;
using VisualInspection.Utils.Net;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class DeleteUsers : Form
    {
        MySQLDatabase mySQLDatabase;

        string[] Info_1 = new string[2];
        string[] Error_1 = new string[2];

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
                //-------------------------------------------------------------------
                //*************************Texty Obrazovky***************************
                //-------------------------------------------------------------------

                lblTextUserList.Text =          "Seznam Uživatelů";
                btnDelete.Text =                "Smazat";

                //-------------------------------------------------------------------
                //***************************Informace*******************************
                //-------------------------------------------------------------------

                Info_1[0] = "Upozornění";
                Info_1[1] = "Jste si jistý, že chcete vybraného uživatele smazat?";

                //-------------------------------------------------------------------
                //*****************************Errory*********************************
                //-------------------------------------------------------------------

                Error_1[0] = "Chyba";
                Error_1[1] = "Osobní číslo nemá správný formát.";

            }
            else if (Translator.Language == Language.ENG)
            {
                //-------------------------------------------------------------------
                //***************************Form Texts******************************
                //-------------------------------------------------------------------

                lblTextUserList.Text =          "Users List";
                btnDelete.Text =                "Delete";

                //-------------------------------------------------------------------
                //**************************Information******************************
                //-------------------------------------------------------------------

                Info_1[0] = "Warning";
                Info_1[1] = "Are you sure you want to delete the selected user?";

                //-------------------------------------------------------------------
                //*****************************Errors********************************
                //-------------------------------------------------------------------

                Error_1[0] = "Error";
                Error_1[1] = "Personal ID is in a wrong format.";

            }
        }

        private void DeleteUsers_VisibleChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lbUsersList.Items.Count; i++)
            {
                if(StringHelper.SearchTextInString(lbUsersList.Items[i].ToString(), tbSearchUser.Text))
                {
                    lbUsersList.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbUsersList.SelectedItem == null || lbUsersList.SelectedItem.ToString() == "") return;

            DialogResult dialogResult = CustomMessageBox_Yes_No.ShowPopup(Info_1[0], Info_1[1]);
            if (dialogResult != DialogResult.Yes) return;

            string[] IDAndName = lbUsersList.SelectedItem.ToString().Split(" | ");

            if(StringHelper.CheckIfTextIsNumber(IDAndName[0]) == false)
            {
                CustomMessageBox.ShowPopup(Error_1[0], Error_1[1]);
                return;
            }

            if (mySQLDatabase.DeleteUserFromDB(int.Parse(IDAndName[0]))) LoadUsers();
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
    }
}
