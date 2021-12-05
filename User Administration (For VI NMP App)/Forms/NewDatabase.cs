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
    public partial class NewDatabase : Form
    {
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

        public NewDatabase()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text =                          "Vytvoření Nové Databáze";
                lblTextDatabaseFolder.Text =    "Složka Databáze";
                btnBrowseDBFolder.Text =        "Procházet";
                lblTextDatabaseName.Text =      "Název Databáze";
                btnCreateDatabase.Text =        "Vytvořit databázi";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text =                          "Create New Database";
                lblTextDatabaseFolder.Text =    "Database Folder";
                btnBrowseDBFolder.Text =        "Browse";
                lblTextDatabaseName.Text =      "Database Name";
                btnCreateDatabase.Text =        "Create Database";
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
            if (string.IsNullOrWhiteSpace(tbDatabaseName.Text))
            {
                
            }
        }
    }
}
