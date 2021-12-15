
namespace User_Administration__For_VI_NMP_App_.Forms
{
    partial class EditUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUsersList = new System.Windows.Forms.ListBox();
            this.btnClearParameters = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblTextUserList = new System.Windows.Forms.Label();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextPersonalID = new System.Windows.Forms.Label();
            this.lblTextFirstName = new System.Windows.Forms.Label();
            this.lblTextLastName = new System.Windows.Forms.Label();
            this.tbPersonalID = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.rdbNewPassword = new System.Windows.Forms.RadioButton();
            this.rdbOldPassword = new System.Windows.Forms.RadioButton();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblTextConfirmPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblTextPassword = new System.Windows.Forms.Label();
            this.perPick = new User_Administration__For_VI_NMP_App_.UserControls.PermissionPicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsersList
            // 
            this.lbUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsersList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsersList.ForeColor = System.Drawing.Color.White;
            this.lbUsersList.FormattingEnabled = true;
            this.lbUsersList.ItemHeight = 20;
            this.lbUsersList.Location = new System.Drawing.Point(12, 63);
            this.lbUsersList.Name = "lbUsersList";
            this.lbUsersList.Size = new System.Drawing.Size(416, 280);
            this.lbUsersList.TabIndex = 33;
            this.lbUsersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbUsersList_MouseDoubleClick);
            // 
            // btnClearParameters
            // 
            this.btnClearParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearParameters.FlatAppearance.BorderSize = 0;
            this.btnClearParameters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnClearParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearParameters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearParameters.ForeColor = System.Drawing.Color.White;
            this.btnClearParameters.Location = new System.Drawing.Point(10, 909);
            this.btnClearParameters.Name = "btnClearParameters";
            this.btnClearParameters.Size = new System.Drawing.Size(185, 50);
            this.btnClearParameters.TabIndex = 35;
            this.btnClearParameters.Text = "Clear Parameters";
            this.btnClearParameters.UseVisualStyleBackColor = false;
            this.btnClearParameters.Click += new System.EventHandler(this.btnClearParameters_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(241, 909);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(185, 50);
            this.btnSaveUser.TabIndex = 34;
            this.btnSaveUser.Text = "Add to Database";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // lblTextUserList
            // 
            this.lblTextUserList.AutoSize = true;
            this.lblTextUserList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextUserList.ForeColor = System.Drawing.Color.White;
            this.lblTextUserList.Location = new System.Drawing.Point(12, 9);
            this.lblTextUserList.Name = "lblTextUserList";
            this.lblTextUserList.Size = new System.Drawing.Size(77, 20);
            this.lblTextUserList.TabIndex = 43;
            this.lblTextUserList.Text = "Users List";
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchUser.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchUser.Location = new System.Drawing.Point(12, 32);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(383, 23);
            this.tbSearchUser.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(401, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSearch.Size = new System.Drawing.Size(27, 23);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTextPersonalID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTextFirstName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTextLastName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPersonalID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFirstName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbLastName, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rdbNewPassword, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.rdbOldPassword, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbConfirmPassword, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblTextConfirmPassword, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblTextPassword, 0, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 349);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.274026F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.1397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 337);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // lblTextPersonalID
            // 
            this.lblTextPersonalID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextPersonalID.AutoSize = true;
            this.lblTextPersonalID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPersonalID.ForeColor = System.Drawing.Color.White;
            this.lblTextPersonalID.Location = new System.Drawing.Point(3, 5);
            this.lblTextPersonalID.Name = "lblTextPersonalID";
            this.lblTextPersonalID.Size = new System.Drawing.Size(89, 20);
            this.lblTextPersonalID.TabIndex = 3;
            this.lblTextPersonalID.Text = "Personal ID";
            // 
            // lblTextFirstName
            // 
            this.lblTextFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextFirstName.AutoSize = true;
            this.lblTextFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextFirstName.ForeColor = System.Drawing.Color.White;
            this.lblTextFirstName.Location = new System.Drawing.Point(3, 55);
            this.lblTextFirstName.Name = "lblTextFirstName";
            this.lblTextFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblTextFirstName.TabIndex = 4;
            this.lblTextFirstName.Text = "First Name";
            // 
            // lblTextLastName
            // 
            this.lblTextLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextLastName.AutoSize = true;
            this.lblTextLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextLastName.ForeColor = System.Drawing.Color.White;
            this.lblTextLastName.Location = new System.Drawing.Point(3, 105);
            this.lblTextLastName.Name = "lblTextLastName";
            this.lblTextLastName.Size = new System.Drawing.Size(84, 20);
            this.lblTextLastName.TabIndex = 5;
            this.lblTextLastName.Text = "Last Name";
            // 
            // tbPersonalID
            // 
            this.tbPersonalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPersonalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPersonalID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPersonalID.ForeColor = System.Drawing.Color.White;
            this.tbPersonalID.Location = new System.Drawing.Point(3, 28);
            this.tbPersonalID.Name = "tbPersonalID";
            this.tbPersonalID.Size = new System.Drawing.Size(411, 20);
            this.tbPersonalID.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(3, 78);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(411, 20);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.ForeColor = System.Drawing.Color.White;
            this.tbLastName.Location = new System.Drawing.Point(3, 128);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(411, 20);
            this.tbLastName.TabIndex = 8;
            // 
            // rdbNewPassword
            // 
            this.rdbNewPassword.AutoSize = true;
            this.rdbNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbNewPassword.ForeColor = System.Drawing.Color.White;
            this.rdbNewPassword.Location = new System.Drawing.Point(3, 192);
            this.rdbNewPassword.Name = "rdbNewPassword";
            this.rdbNewPassword.Size = new System.Drawing.Size(115, 19);
            this.rdbNewPassword.TabIndex = 14;
            this.rdbNewPassword.TabStop = true;
            this.rdbNewPassword.Text = "New Password";
            this.rdbNewPassword.UseVisualStyleBackColor = true;
            this.rdbNewPassword.CheckedChanged += new System.EventHandler(this.rbdPasswordSel_CheckedChanged);
            // 
            // rdbOldPassword
            // 
            this.rdbOldPassword.AutoSize = true;
            this.rdbOldPassword.Checked = true;
            this.rdbOldPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbOldPassword.ForeColor = System.Drawing.Color.White;
            this.rdbOldPassword.Location = new System.Drawing.Point(3, 167);
            this.rdbOldPassword.Name = "rdbOldPassword";
            this.rdbOldPassword.Size = new System.Drawing.Size(110, 19);
            this.rdbOldPassword.TabIndex = 13;
            this.rdbOldPassword.TabStop = true;
            this.rdbOldPassword.Text = "Old Password";
            this.rdbOldPassword.UseVisualStyleBackColor = true;
            this.rdbOldPassword.CheckedChanged += new System.EventHandler(this.rbdPasswordSel_CheckedChanged);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.tbConfirmPassword.Location = new System.Drawing.Point(3, 305);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(411, 20);
            this.tbConfirmPassword.TabIndex = 12;
            // 
            // lblTextConfirmPassword
            // 
            this.lblTextConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextConfirmPassword.AutoSize = true;
            this.lblTextConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblTextConfirmPassword.Location = new System.Drawing.Point(3, 282);
            this.lblTextConfirmPassword.Name = "lblTextConfirmPassword";
            this.lblTextConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.lblTextConfirmPassword.TabIndex = 10;
            this.lblTextConfirmPassword.Text = "Confirm Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(3, 255);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(411, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // lblTextPassword
            // 
            this.lblTextPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextPassword.AutoSize = true;
            this.lblTextPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPassword.ForeColor = System.Drawing.Color.White;
            this.lblTextPassword.Location = new System.Drawing.Point(3, 232);
            this.lblTextPassword.Name = "lblTextPassword";
            this.lblTextPassword.Size = new System.Drawing.Size(76, 20);
            this.lblTextPassword.TabIndex = 9;
            this.lblTextPassword.Text = "Password";
            // 
            // perPick
            // 
            this.perPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.perPick.Location = new System.Drawing.Point(6, 692);
            this.perPick.Name = "perPick";
            this.perPick.Size = new System.Drawing.Size(425, 215);
            this.perPick.TabIndex = 48;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(440, 971);
            this.Controls.Add(this.perPick);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchUser);
            this.Controls.Add(this.lblTextUserList);
            this.Controls.Add(this.btnClearParameters);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.lbUsersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Users";
            this.VisibleChanged += new System.EventHandler(this.EditUsers_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbUsersList;
        private System.Windows.Forms.Button btnClearParameters;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblTextUserList;
        private System.Windows.Forms.TextBox tbSearchUser;
        private System.Windows.Forms.Button btnSearch;
        private UserControls.PermissionPicker perPick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTextPersonalID;
        private System.Windows.Forms.Label lblTextFirstName;
        private System.Windows.Forms.Label lblTextLastName;
        private System.Windows.Forms.TextBox tbPersonalID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblTextPassword;
        private System.Windows.Forms.Label lblTextConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.RadioButton rdbNewPassword;
        private System.Windows.Forms.RadioButton rdbOldPassword;
    }
}