﻿
namespace User_Administration__For_VI_NMP_App_.Forms
{
    partial class AddUsers
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
            this.lblTextUserName = new System.Windows.Forms.Label();
            this.lblTextPassword = new System.Windows.Forms.Label();
            this.lblTextConfirmPassword = new System.Windows.Forms.Label();
            this.tbUseName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnClearParameters = new System.Windows.Forms.Button();
            this.lbPermissionsList = new System.Windows.Forms.ListBox();
            this.lbUserPermissions = new System.Windows.Forms.ListBox();
            this.btnAddPermission = new System.Windows.Forms.Button();
            this.btnRemovePermission = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextPermissionsList = new System.Windows.Forms.Label();
            this.lblTextUserPermissions = new System.Windows.Forms.Label();
            this.lblDBPath = new System.Windows.Forms.Label();
            this.lblTextDatabasePath = new System.Windows.Forms.Label();
            this.btnBrowseDBPath = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // tbUseName
            // 
            this.tbUseName.BackColor = System.Drawing.Color.Gray;
            this.tbUseName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbUseName.Location = new System.Drawing.Point(3, 35);
            this.tbUseName.Name = "tbUseName";
            this.tbUseName.Size = new System.Drawing.Size(411, 23);
            this.tbUseName.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Gray;
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPassword.Location = new System.Drawing.Point(3, 99);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(411, 23);
            this.tbPassword.TabIndex = 7;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.Gray;
            this.tbConfirmPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbConfirmPassword.Location = new System.Drawing.Point(3, 163);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(411, 23);
            this.tbConfirmPassword.TabIndex = 8;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(224, 525);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(160, 50);
            this.btnSaveUser.TabIndex = 9;
            this.btnSaveUser.Text = "Add to Database";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            // 
            // btnClearParameters
            // 
            this.btnClearParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearParameters.FlatAppearance.BorderSize = 0;
            this.btnClearParameters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnClearParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearParameters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearParameters.ForeColor = System.Drawing.Color.White;
            this.btnClearParameters.Location = new System.Drawing.Point(58, 525);
            this.btnClearParameters.Name = "btnClearParameters";
            this.btnClearParameters.Size = new System.Drawing.Size(160, 50);
            this.btnClearParameters.TabIndex = 10;
            this.btnClearParameters.Text = "Clear Parameters";
            this.btnClearParameters.UseVisualStyleBackColor = false;
            // 
            // lbPermissionsList
            // 
            this.lbPermissionsList.BackColor = System.Drawing.Color.Gray;
            this.lbPermissionsList.FormattingEnabled = true;
            this.lbPermissionsList.ItemHeight = 15;
            this.lbPermissionsList.Location = new System.Drawing.Point(12, 326);
            this.lbPermissionsList.Name = "lbPermissionsList";
            this.lbPermissionsList.Size = new System.Drawing.Size(185, 184);
            this.lbPermissionsList.TabIndex = 11;
            // 
            // lbUserPermissions
            // 
            this.lbUserPermissions.BackColor = System.Drawing.Color.Gray;
            this.lbUserPermissions.FormattingEnabled = true;
            this.lbUserPermissions.ItemHeight = 15;
            this.lbUserPermissions.Location = new System.Drawing.Point(243, 326);
            this.lbUserPermissions.Name = "lbUserPermissions";
            this.lbUserPermissions.Size = new System.Drawing.Size(186, 184);
            this.lbUserPermissions.TabIndex = 12;
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPermission.FlatAppearance.BorderSize = 0;
            this.btnAddPermission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAddPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPermission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPermission.ForeColor = System.Drawing.Color.White;
            this.btnAddPermission.Location = new System.Drawing.Point(203, 326);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.Size = new System.Drawing.Size(34, 32);
            this.btnAddPermission.TabIndex = 13;
            this.btnAddPermission.Text = "-->";
            this.btnAddPermission.UseVisualStyleBackColor = false;
            // 
            // btnRemovePermission
            // 
            this.btnRemovePermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemovePermission.FlatAppearance.BorderSize = 0;
            this.btnRemovePermission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnRemovePermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePermission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemovePermission.ForeColor = System.Drawing.Color.White;
            this.btnRemovePermission.Location = new System.Drawing.Point(203, 364);
            this.btnRemovePermission.Name = "btnRemovePermission";
            this.btnRemovePermission.Size = new System.Drawing.Size(34, 32);
            this.btnRemovePermission.TabIndex = 14;
            this.btnRemovePermission.Text = "<--";
            this.btnRemovePermission.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTextUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTextPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTextConfirmPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbUseName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbConfirmPassword, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 197);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblTextPermissionsList
            // 
            this.lblTextPermissionsList.AutoSize = true;
            this.lblTextPermissionsList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPermissionsList.ForeColor = System.Drawing.Color.White;
            this.lblTextPermissionsList.Location = new System.Drawing.Point(12, 303);
            this.lblTextPermissionsList.Name = "lblTextPermissionsList";
            this.lblTextPermissionsList.Size = new System.Drawing.Size(122, 20);
            this.lblTextPermissionsList.TabIndex = 18;
            this.lblTextPermissionsList.Text = "Permissions List";
            // 
            // lblTextUserPermissions
            // 
            this.lblTextUserPermissions.AutoSize = true;
            this.lblTextUserPermissions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextUserPermissions.ForeColor = System.Drawing.Color.White;
            this.lblTextUserPermissions.Location = new System.Drawing.Point(243, 303);
            this.lblTextUserPermissions.Name = "lblTextUserPermissions";
            this.lblTextUserPermissions.Size = new System.Drawing.Size(129, 20);
            this.lblTextUserPermissions.TabIndex = 19;
            this.lblTextUserPermissions.Text = "User Permissions";
            // 
            // lblDBPath
            // 
            this.lblDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDBPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDBPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDBPath.ForeColor = System.Drawing.Color.Silver;
            this.lblDBPath.Location = new System.Drawing.Point(114, 39);
            this.lblDBPath.Name = "lblDBPath";
            this.lblDBPath.Size = new System.Drawing.Size(315, 20);
            this.lblDBPath.TabIndex = 26;
            this.lblDBPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextDatabasePath
            // 
            this.lblTextDatabasePath.AutoSize = true;
            this.lblTextDatabasePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextDatabasePath.ForeColor = System.Drawing.Color.White;
            this.lblTextDatabasePath.Location = new System.Drawing.Point(11, 9);
            this.lblTextDatabasePath.Name = "lblTextDatabasePath";
            this.lblTextDatabasePath.Size = new System.Drawing.Size(110, 20);
            this.lblTextDatabasePath.TabIndex = 25;
            this.lblTextDatabasePath.Text = "Database Path";
            // 
            // btnBrowseDBPath
            // 
            this.btnBrowseDBPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseDBPath.FlatAppearance.BorderSize = 0;
            this.btnBrowseDBPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnBrowseDBPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDBPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseDBPath.ForeColor = System.Drawing.Color.White;
            this.btnBrowseDBPath.Location = new System.Drawing.Point(14, 32);
            this.btnBrowseDBPath.Name = "btnBrowseDBPath";
            this.btnBrowseDBPath.Size = new System.Drawing.Size(86, 33);
            this.btnBrowseDBPath.TabIndex = 24;
            this.btnBrowseDBPath.Text = "Browse";
            this.btnBrowseDBPath.UseVisualStyleBackColor = false;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(442, 591);
            this.Controls.Add(this.lblDBPath);
            this.Controls.Add(this.lblTextDatabasePath);
            this.Controls.Add(this.btnBrowseDBPath);
            this.Controls.Add(this.lblTextUserPermissions);
            this.Controls.Add(this.lblTextPermissionsList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRemovePermission);
            this.Controls.Add(this.btnAddPermission);
            this.Controls.Add(this.lbUserPermissions);
            this.Controls.Add(this.lbPermissionsList);
            this.Controls.Add(this.btnClearParameters);
            this.Controls.Add(this.btnSaveUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Users";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTextUserName;
        private System.Windows.Forms.Label lblTextPassword;
        private System.Windows.Forms.Label lblTextConfirmPassword;
        private System.Windows.Forms.TextBox tbUseName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnClearParameters;
        private System.Windows.Forms.ListBox lbPermissionsList;
        private System.Windows.Forms.ListBox lbUserPermissions;
        private System.Windows.Forms.Button btnAddPermission;
        private System.Windows.Forms.Button btnRemovePermission;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTextPermissionsList;
        private System.Windows.Forms.Label lblTextUserPermissions;
        private System.Windows.Forms.Label lblDBPath;
        private System.Windows.Forms.Label lblTextDatabasePath;
        private System.Windows.Forms.Button btnBrowseDBPath;
    }
}