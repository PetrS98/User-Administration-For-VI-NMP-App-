
namespace User_Administration__For_VI_NMP_App_.Forms
{
    partial class NewDatabase
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
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextDatabaseName = new System.Windows.Forms.Label();
            this.tbDatabaseName = new System.Windows.Forms.TextBox();
            this.lblDBFolder = new System.Windows.Forms.Label();
            this.lblTextDatabaseFolder = new System.Windows.Forms.Label();
            this.btnBrowseDBFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateDatabase.Enabled = false;
            this.btnCreateDatabase.FlatAppearance.BorderSize = 0;
            this.btnCreateDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnCreateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDatabase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateDatabase.ForeColor = System.Drawing.Color.White;
            this.btnCreateDatabase.Location = new System.Drawing.Point(254, 93);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(152, 42);
            this.btnCreateDatabase.TabIndex = 2;
            this.btnCreateDatabase.Text = "Create Database";
            this.btnCreateDatabase.UseVisualStyleBackColor = false;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTextDatabaseName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbDatabaseName, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 60);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // lblTextDatabaseName
            // 
            this.lblTextDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextDatabaseName.AutoSize = true;
            this.lblTextDatabaseName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextDatabaseName.ForeColor = System.Drawing.Color.White;
            this.lblTextDatabaseName.Location = new System.Drawing.Point(3, 10);
            this.lblTextDatabaseName.Name = "lblTextDatabaseName";
            this.lblTextDatabaseName.Size = new System.Drawing.Size(120, 20);
            this.lblTextDatabaseName.TabIndex = 3;
            this.lblTextDatabaseName.Text = "Database Name";
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.BackColor = System.Drawing.Color.Gray;
            this.tbDatabaseName.Enabled = false;
            this.tbDatabaseName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDatabaseName.Location = new System.Drawing.Point(3, 33);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Size = new System.Drawing.Size(198, 23);
            this.tbDatabaseName.TabIndex = 6;
            // 
            // lblDBFolder
            // 
            this.lblDBFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDBFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDBFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDBFolder.ForeColor = System.Drawing.Color.Silver;
            this.lblDBFolder.Location = new System.Drawing.Point(112, 39);
            this.lblDBFolder.Name = "lblDBFolder";
            this.lblDBFolder.Size = new System.Drawing.Size(315, 20);
            this.lblDBFolder.TabIndex = 23;
            this.lblDBFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextDatabaseFolder
            // 
            this.lblTextDatabaseFolder.AutoSize = true;
            this.lblTextDatabaseFolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextDatabaseFolder.ForeColor = System.Drawing.Color.White;
            this.lblTextDatabaseFolder.Location = new System.Drawing.Point(9, 9);
            this.lblTextDatabaseFolder.Name = "lblTextDatabaseFolder";
            this.lblTextDatabaseFolder.Size = new System.Drawing.Size(122, 20);
            this.lblTextDatabaseFolder.TabIndex = 22;
            this.lblTextDatabaseFolder.Text = "Database Folder";
            // 
            // btnBrowseDBFolder
            // 
            this.btnBrowseDBFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseDBFolder.FlatAppearance.BorderSize = 0;
            this.btnBrowseDBFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnBrowseDBFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDBFolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseDBFolder.ForeColor = System.Drawing.Color.White;
            this.btnBrowseDBFolder.Location = new System.Drawing.Point(12, 32);
            this.btnBrowseDBFolder.Name = "btnBrowseDBFolder";
            this.btnBrowseDBFolder.Size = new System.Drawing.Size(86, 33);
            this.btnBrowseDBFolder.TabIndex = 21;
            this.btnBrowseDBFolder.Text = "Browse";
            this.btnBrowseDBFolder.UseVisualStyleBackColor = false;
            this.btnBrowseDBFolder.Click += new System.EventHandler(this.btnBrowseDBFolder_Click);
            // 
            // NewDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(439, 154);
            this.Controls.Add(this.lblDBFolder);
            this.Controls.Add(this.lblTextDatabaseFolder);
            this.Controls.Add(this.btnBrowseDBFolder);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCreateDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDatabase_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTextDatabaseName;
        private System.Windows.Forms.TextBox tbDatabaseName;
        private System.Windows.Forms.Label lblDBFolder;
        private System.Windows.Forms.Label lblTextDatabaseFolder;
        private System.Windows.Forms.Button btnBrowseDBFolder;
    }
}