using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms;
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class NewDatabase : Form
    {
        Database database;

        private string databaseFolderPath;
        public string DatabaseFolderPath 
        {
            get
            {
                return databaseFolderPath;
            }
            set
            {
                databaseFolderPath = value;
                lblDBFolder.Text = databaseFolderPath;
            }
        }

        private string[] Error_1 = new string[2];
        private string[] Error_2 = new string[2];
        private string[] Error_3 = new string[2];

        public NewDatabase()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;

            database = new Database();
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                //-------------------------------------------------------------------
                //*************************Texty Obrazovky***************************
                //-------------------------------------------------------------------

                Text =                          "Vytvoření Nové Databáze";
                lblTextDatabaseFolder.Text =    "Složka Databáze";
                btnBrowseDBFolder.Text =        "Procházet";
                lblTextDatabaseName.Text =      "Název Databáze";
                btnCreateDatabase.Text =        "Vytvořit databázi";

                //-------------------------------------------------------------------
                //*****************************Erory*********************************
                //-------------------------------------------------------------------

                Error_1[0] = "Chyba";
                Error_1[1] = "Cesta pro databázi nesmí být prázdná!!!";
                Error_2[0] = "Chyba";
                Error_2[1] = "Cesta pro databázi neexistuje!!!";
                Error_3[0] = "Chyba";
                Error_3[1] = "Název databáze nesmí být prázdný!!!";

            }
            else if (Translator.Language == Language.ENG)
            {
                //-------------------------------------------------------------------
                //***************************Form Texts******************************
                //-------------------------------------------------------------------

                Text =                          "Create New Database";
                lblTextDatabaseFolder.Text =    "Database Folder";
                btnBrowseDBFolder.Text =        "Browse";
                lblTextDatabaseName.Text =      "Database Name";
                btnCreateDatabase.Text =        "Create Database";

                //-------------------------------------------------------------------
                //*****************************Errors********************************
                //-------------------------------------------------------------------

                Error_1[0] = "Error";
                Error_1[1] = "The path for database must not be empty!!!";
                Error_2[0] = "Error";
                Error_2[1] = "The path for database does not exist!!!";
                Error_3[0] = "Error";
                Error_3[1] = "The database name must not be empty!!!";
            }
        }

        private void btnBrowseDBFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.ShowDialog();
            DatabaseFolderPath = folderBrowserDialog.SelectedPath;

            tbDatabaseName.Enabled = true;
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            string FullDBPath = "";

            if(DatabaseFolderPath == "" || DatabaseFolderPath == null)
            {
                CustomMessageBox.ShowPopup(Error_1[0], Error_1[1]);
                return;
            }

            if (Directory.Exists(DatabaseFolderPath) == false)
            {
                CustomMessageBox.ShowPopup(Error_2[0], Error_2[1]);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbDatabaseName.Text))
            {
                CustomMessageBox.ShowPopup(Error_3[0], Error_3[1]);
                return;
            }

            FullDBPath = DatabaseFolderPath + "\\" + tbDatabaseName.Text;

            //database.CreateDatabase(FullDBPath);
        }
    }
}
