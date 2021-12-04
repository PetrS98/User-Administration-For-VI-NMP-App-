using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;
using User_Administration__For_VI_NMP_App_.Forms;

namespace User_Administration__For_VI_NMP_App_
{
    public partial class MainMenu : Form
    {
        private NewDatabase newDatabase;
        private AddUsers addUsers;
        private DeleteUsers deleteUsers;
        private EditUsers editUsers;

        public MainMenu()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;

            newDatabase = new NewDatabase();
            addUsers = new AddUsers();
            deleteUsers = new DeleteUsers();
            editUsers = new EditUsers();
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text =                      "Administrace Databáze Uživatelů";
                btnCreateDatabase.Text =    "Vytvoření Databáze";
                btnAddUser.Text =           "Přidání Uživatele";
                btnEditUser.Text =          "Editace Uživatele";
                btnDeleteUser.Text =        "Smazání Uživatele";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text =                      "User Database Administration";
                btnCreateDatabase.Text =    "Create Database";
                btnAddUser.Text =           "Add User";
                btnEditUser.Text =          "Edit User";
                btnDeleteUser.Text =        "Delete User";
            }

        }

        private void pbLanguage_Click(object sender, EventArgs e)
        {
            if (Translator.Language == Language.CZ)
            {
                pbLanguage.Image.Dispose();
                pbLanguage.Image = Properties.Resources.cz;
                Translator.Language = Language.ENG;
            }
            else
            {
                pbLanguage.Image.Dispose();
                pbLanguage.Image = Properties.Resources.gb;
                Translator.Language = Language.CZ;
            }
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            var form = newDatabase;

            if (form.Visible) form.Hide();
            else form.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = addUsers;

            if (form.Visible) form.Hide();
            else form.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var form = editUsers;

            if (form.Visible) form.Hide();
            else form.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var form = deleteUsers;

            if (form.Visible) form.Hide();
            else form.Show();
        }
    }
}
