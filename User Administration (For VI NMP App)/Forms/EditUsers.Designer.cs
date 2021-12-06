
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextUserName = new System.Windows.Forms.Label();
            this.lblTextPassword = new System.Windows.Forms.Label();
            this.lblTextConfirmPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnClearParameters = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblTextUserList = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.permissionPicker1 = new User_Administration__For_VI_NMP_App_.UserControls.PermissionPicker();
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTextUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTextPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTextConfirmPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbConfirmPassword, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 349);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 197);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // lblTextUserName
            // 
            this.lblTextUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextUserName.AutoSize = true;
            this.lblTextUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextUserName.ForeColor = System.Drawing.Color.White;
            this.lblTextUserName.Location = new System.Drawing.Point(3, 12);
            this.lblTextUserName.Name = "lblTextUserName";
            this.lblTextUserName.Size = new System.Drawing.Size(87, 20);
            this.lblTextUserName.TabIndex = 3;
            this.lblTextUserName.Text = "User Name";
            // 
            // lblTextPassword
            // 
            this.lblTextPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextPassword.AutoSize = true;
            this.lblTextPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPassword.ForeColor = System.Drawing.Color.White;
            this.lblTextPassword.Location = new System.Drawing.Point(3, 76);
            this.lblTextPassword.Name = "lblTextPassword";
            this.lblTextPassword.Size = new System.Drawing.Size(76, 20);
            this.lblTextPassword.TabIndex = 4;
            this.lblTextPassword.Text = "Password";
            // 
            // lblTextConfirmPassword
            // 
            this.lblTextConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextConfirmPassword.AutoSize = true;
            this.lblTextConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblTextConfirmPassword.Location = new System.Drawing.Point(3, 140);
            this.lblTextConfirmPassword.Name = "lblTextConfirmPassword";
            this.lblTextConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.lblTextConfirmPassword.TabIndex = 5;
            this.lblTextConfirmPassword.Text = "Confirm Password";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserName.ForeColor = System.Drawing.Color.White;
            this.tbUserName.Location = new System.Drawing.Point(3, 35);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(410, 20);
            this.tbUserName.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(3, 99);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(410, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.tbConfirmPassword.Location = new System.Drawing.Point(3, 163);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(410, 20);
            this.tbConfirmPassword.TabIndex = 8;
            // 
            // btnClearParameters
            // 
            this.btnClearParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearParameters.FlatAppearance.BorderSize = 0;
            this.btnClearParameters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnClearParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearParameters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearParameters.ForeColor = System.Drawing.Color.White;
            this.btnClearParameters.Location = new System.Drawing.Point(244, 769);
            this.btnClearParameters.Name = "btnClearParameters";
            this.btnClearParameters.Size = new System.Drawing.Size(185, 50);
            this.btnClearParameters.TabIndex = 35;
            this.btnClearParameters.Text = "Clear Parameters";
            this.btnClearParameters.UseVisualStyleBackColor = false;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(13, 769);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(185, 50);
            this.btnSaveUser.TabIndex = 34;
            this.btnSaveUser.Text = "Add to Database";
            this.btnSaveUser.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 23);
            this.textBox1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(401, 32);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // permissionPicker1
            // 
            this.permissionPicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.permissionPicker1.Location = new System.Drawing.Point(10, 552);
            this.permissionPicker1.Name = "permissionPicker1";
            this.permissionPicker1.Size = new System.Drawing.Size(425, 215);
            this.permissionPicker1.TabIndex = 46;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(440, 831);
            this.Controls.Add(this.permissionPicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTextUserList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnClearParameters);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.lbUsersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Users";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbUsersList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTextUserName;
        private System.Windows.Forms.Label lblTextPassword;
        private System.Windows.Forms.Label lblTextConfirmPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnClearParameters;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblTextUserList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private UserControls.PermissionPicker permissionPicker1;
    }
}