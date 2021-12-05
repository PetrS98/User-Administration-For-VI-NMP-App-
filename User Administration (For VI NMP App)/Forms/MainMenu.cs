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
using User_Administration__For_VI_NMP_App_.Forms.MessageBoxes;

namespace User_Administration__For_VI_NMP_App_
{
    public partial class MainMenu : Form
    {
        private readonly Color SELECTED_BUTTON_COLOR = Color.FromArgb(128, 0, 128);
        private readonly Color DEFAULT_BUTTON_COLOR = Color.FromArgb(64,64,64);

        private NewDatabase newDatabase;
        private AddUsers addUsers;
        private DeleteUsers deleteUsers;
        private EditUsers editUsers;

        private bool mouseDown;
        private Point lastLocation;

        private Button activeButton;
        public Button ActiveButton
        {
            get { return activeButton; }
            set 
            {
                if (activeButton != null)
                {
                    activeButton.BackColor = DEFAULT_BUTTON_COLOR;
                }

                activeButton = value;

                activeButton.BackColor = SELECTED_BUTTON_COLOR;
            }
        }

        private Form activePage;
        public Form ActivePage
        {
            get { return activePage; }
            set 
            { 
                if(activePage != null)
                {
                    activePage.Hide();
                }

                activePage = value;

                activePage.Show();
            }
        }



        public MainMenu()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;

            newDatabase = new NewDatabase();
            addUsers = new AddUsers();
            deleteUsers = new DeleteUsers();
            editUsers = new EditUsers();

            newDatabase.TopLevel = false;
            newDatabase.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(newDatabase);

            addUsers.TopLevel = false;
            addUsers.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(addUsers);

            deleteUsers.TopLevel = false;
            deleteUsers.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(deleteUsers);

            editUsers.TopLevel = false;
            editUsers.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(editUsers);
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text =                      "Administrace Databáze Uživatelů";
                lblTitle.Text =             "Administrace Databáze Uživatelů";
                btnCreateDatabase.Text =    "Vytvoření Databáze";
                btnAddUser.Text =           "Přidání Uživatele";
                btnEditUser.Text =          "Editace Uživatele";
                btnDeleteUser.Text =        "Smazání Uživatele";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text =                      "User Database Administration";
                lblTitle.Text =             "User Database Administration";
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
            ActiveButton = sender as Button;
            ActivePage = newDatabase;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ActiveButton = sender as Button;
            ActivePage = addUsers;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            ActiveButton = sender as Button;
            ActivePage = editUsers;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ActiveButton = sender as Button;
            ActivePage = deleteUsers;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowPopup("fdhgvhfadfvc", "ajhbsdfhjbdihjfbvijhbdnfjhvbibwneidjhbvncihjwebdsnvcbnwsebcnvbhdjsevcwbnsvcbnwsehjvcbnhjwds");

            var tmp = CustomMessageBox_Yes_No.ShowPopup("jdvnjsefnvjnaev", "iooiuuioj545454554");

            if(tmp == DialogResult.Yes)
            {
                CustomMessageBox.ShowPopup("Yes", "");
            }
            else if(tmp == DialogResult.No)
            {
                CustomMessageBox.ShowPopup("No", "");
            }
        }
    }
}
