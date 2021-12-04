
namespace User_Administration__For_VI_NMP_App_.Forms
{
    partial class DeleteUsers
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
            this.lblDBPath = new System.Windows.Forms.Label();
            this.lblTextDatabasePath = new System.Windows.Forms.Label();
            this.btnBrowseDBPath = new System.Windows.Forms.Button();
            this.lblTextUserList = new System.Windows.Forms.Label();
            this.lbUsersList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDBPath
            // 
            this.lblDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDBPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDBPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDBPath.ForeColor = System.Drawing.Color.Silver;
            this.lblDBPath.Location = new System.Drawing.Point(112, 37);
            this.lblDBPath.Name = "lblDBPath";
            this.lblDBPath.Size = new System.Drawing.Size(315, 20);
            this.lblDBPath.TabIndex = 29;
            this.lblDBPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextDatabasePath
            // 
            this.lblTextDatabasePath.AutoSize = true;
            this.lblTextDatabasePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextDatabasePath.ForeColor = System.Drawing.Color.White;
            this.lblTextDatabasePath.Location = new System.Drawing.Point(9, 7);
            this.lblTextDatabasePath.Name = "lblTextDatabasePath";
            this.lblTextDatabasePath.Size = new System.Drawing.Size(110, 20);
            this.lblTextDatabasePath.TabIndex = 28;
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
            this.btnBrowseDBPath.Location = new System.Drawing.Point(12, 30);
            this.btnBrowseDBPath.Name = "btnBrowseDBPath";
            this.btnBrowseDBPath.Size = new System.Drawing.Size(86, 33);
            this.btnBrowseDBPath.TabIndex = 27;
            this.btnBrowseDBPath.Text = "Browse";
            this.btnBrowseDBPath.UseVisualStyleBackColor = false;
            // 
            // lblTextUserList
            // 
            this.lblTextUserList.AutoSize = true;
            this.lblTextUserList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextUserList.ForeColor = System.Drawing.Color.White;
            this.lblTextUserList.Location = new System.Drawing.Point(83, 79);
            this.lblTextUserList.Name = "lblTextUserList";
            this.lblTextUserList.Size = new System.Drawing.Size(77, 20);
            this.lblTextUserList.TabIndex = 45;
            this.lblTextUserList.Text = "Users List";
            // 
            // lbUsersList
            // 
            this.lbUsersList.BackColor = System.Drawing.Color.Gray;
            this.lbUsersList.FormattingEnabled = true;
            this.lbUsersList.ItemHeight = 15;
            this.lbUsersList.Location = new System.Drawing.Point(83, 102);
            this.lbUsersList.Name = "lbUsersList";
            this.lbUsersList.Size = new System.Drawing.Size(269, 184);
            this.lbUsersList.TabIndex = 44;
            // 
            // DeleteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(440, 298);
            this.Controls.Add(this.lblTextUserList);
            this.Controls.Add(this.lbUsersList);
            this.Controls.Add(this.lblDBPath);
            this.Controls.Add(this.lblTextDatabasePath);
            this.Controls.Add(this.btnBrowseDBPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeleteUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteUsers_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBPath;
        private System.Windows.Forms.Label lblTextDatabasePath;
        private System.Windows.Forms.Button btnBrowseDBPath;
        private System.Windows.Forms.Label lblTextUserList;
        private System.Windows.Forms.ListBox lbUsersList;
    }
}