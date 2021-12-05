
namespace User_Administration__For_VI_NMP_App_.Classes
{
    partial class ConnectToDatabase
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextIpAddress = new System.Windows.Forms.Label();
            this.iabServerIp = new VisualInspection.App.UserControls.IPAddressBox();
            this.lblTextUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblTextPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblTextConnectionStatus = new System.Windows.Forms.Label();
            this.clientStatusDot1 = new User_Administration__For_VI_NMP_App_.UserControls.ClientStatusDot();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTextIpAddress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iabServerIp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTextUserName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTextPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTextConnectionStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientStatusDot1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTextIpAddress
            // 
            this.lblTextIpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextIpAddress.AutoSize = true;
            this.lblTextIpAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextIpAddress.ForeColor = System.Drawing.Color.White;
            this.lblTextIpAddress.Location = new System.Drawing.Point(3, 13);
            this.lblTextIpAddress.Name = "lblTextIpAddress";
            this.lblTextIpAddress.Size = new System.Drawing.Size(133, 20);
            this.lblTextIpAddress.TabIndex = 0;
            this.lblTextIpAddress.Text = "Server IP Address";
            // 
            // iabServerIp
            // 
            this.iabServerIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iabServerIp.BlinkBackColor = System.Drawing.Color.Salmon;
            this.iabServerIp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iabServerIp.ForeColor = System.Drawing.Color.White;
            this.iabServerIp.IPAddress = "";
            this.iabServerIp.IPAddressAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iabServerIp.Location = new System.Drawing.Point(4, 37);
            this.iabServerIp.Margin = new System.Windows.Forms.Padding(4);
            this.iabServerIp.Name = "iabServerIp";
            this.iabServerIp.Size = new System.Drawing.Size(178, 20);
            this.iabServerIp.TabIndex = 1;
            this.iabServerIp.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // lblTextUserName
            // 
            this.lblTextUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextUserName.AutoSize = true;
            this.lblTextUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextUserName.ForeColor = System.Drawing.Color.White;
            this.lblTextUserName.Location = new System.Drawing.Point(3, 79);
            this.lblTextUserName.Name = "lblTextUserName";
            this.lblTextUserName.Size = new System.Drawing.Size(87, 20);
            this.lblTextUserName.TabIndex = 2;
            this.lblTextUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserName.ForeColor = System.Drawing.Color.White;
            this.tbUserName.Location = new System.Drawing.Point(3, 102);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(178, 20);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTextPassword
            // 
            this.lblTextPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextPassword.AutoSize = true;
            this.lblTextPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPassword.ForeColor = System.Drawing.Color.White;
            this.lblTextPassword.Location = new System.Drawing.Point(3, 145);
            this.lblTextPassword.Name = "lblTextPassword";
            this.lblTextPassword.Size = new System.Drawing.Size(76, 20);
            this.lblTextPassword.TabIndex = 4;
            this.lblTextPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(3, 168);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(178, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTextConnectionStatus
            // 
            this.lblTextConnectionStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTextConnectionStatus.AutoSize = true;
            this.lblTextConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextConnectionStatus.ForeColor = System.Drawing.Color.White;
            this.lblTextConnectionStatus.Location = new System.Drawing.Point(227, 13);
            this.lblTextConnectionStatus.Name = "lblTextConnectionStatus";
            this.lblTextConnectionStatus.Size = new System.Drawing.Size(136, 20);
            this.lblTextConnectionStatus.TabIndex = 7;
            this.lblTextConnectionStatus.Text = "Connection Status";
            // 
            // clientStatusDot1
            // 
            this.clientStatusDot1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientStatusDot1.Client = null;
            this.clientStatusDot1.Location = new System.Drawing.Point(283, 36);
            this.clientStatusDot1.Name = "clientStatusDot1";
            this.clientStatusDot1.Size = new System.Drawing.Size(25, 25);
            this.clientStatusDot1.Status = VisualInspection.Utils.Net.ClientStatus.Disconnected;
            this.clientStatusDot1.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(12, 220);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(194, 50);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(212, 220);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(194, 50);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // ConnectToDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(431, 290);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectToDatabase";
            this.Text = "ConnectToDatabase";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTextIpAddress;
        private VisualInspection.App.UserControls.IPAddressBox iabServerIp;
        private System.Windows.Forms.Label lblTextUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblTextPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblTextConnectionStatus;
        public UserControls.ClientStatusDot clientStatusDot1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
    }
}