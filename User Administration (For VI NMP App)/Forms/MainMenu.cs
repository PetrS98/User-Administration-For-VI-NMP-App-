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

        private MySQLDatabase mySQLDatabase = new MySQLDatabase();

        private ConnectToDatabase connectToDatabase;
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
            CustomMessageBox_Yes_No.ShowPopup("asdlůfijk", "asdfsadf");
            Translator.LanguageChanged += Translate;

            connectToDatabase = new ConnectToDatabase(mySQLDatabase);
            addUsers = new AddUsers(mySQLDatabase);
            deleteUsers = new DeleteUsers(mySQLDatabase);
            editUsers = new EditUsers(mySQLDatabase);

            connectToDatabase.clientStatusDot1.Client = mySQLDatabase;

            connectToDatabase.TopLevel = false;
            connectToDatabase.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(connectToDatabase);

            addUsers.TopLevel = false;
            addUsers.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(addUsers);

            deleteUsers.TopLevel = false;
            deleteUsers.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(deleteUsers);

            editUsers.TopLevel = false;
            editUsers.Dock = DockStyle.Fill;
            pagePanel.Controls.Add(editUsers);

            Translator.Language = Language.ENG;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                Text =                      "Administrace Databáze Uživatelů";
                lblTitle.Text =             "Administrace Databáze Uživatelů";
                btnCreateDatabase.Text =    "Připojení k Databázi";
                btnAddUser.Text =           "Přidání Uživatele";
                btnEditUser.Text =          "Editace Uživatele";
                btnDeleteUser.Text =        "Smazání Uživatele";
            }
            else if (Translator.Language == Language.ENG)
            {
                Text =                      "User Database Administration";
                lblTitle.Text =             "User Database Administration";
                btnCreateDatabase.Text =    "Connect to Database";
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

        private void btnConnectToDatabase_Click(object sender, EventArgs e)
        {
            ActiveButton = sender as Button;
            ActivePage = connectToDatabase;
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
    }
}
