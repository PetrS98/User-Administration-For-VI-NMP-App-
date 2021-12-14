﻿
namespace User_Administration__For_VI_NMP_App_.Forms
{
    partial class AboutApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCopyr = new System.Windows.Forms.Label();
            this.lblRestriction = new System.Windows.Forms.Label();
            this.llblCompanyWebsite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Visual Inspection Database Administration";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(12, 52);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(400, 40);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Application Version: 1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.ForeColor = System.Drawing.Color.White;
            this.lblCreator.Location = new System.Drawing.Point(12, 161);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(252, 40);
            this.lblCreator.TabIndex = 2;
            this.lblCreator.Text = "Creator: Petr Staněk";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(12, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(252, 40);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email: petr.stanek@nexentire.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(12, 241);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(252, 40);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Tel: +420 703 496 310";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyr
            // 
            this.lblCopyr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCopyr.ForeColor = System.Drawing.Color.White;
            this.lblCopyr.Location = new System.Drawing.Point(12, 291);
            this.lblCopyr.Name = "lblCopyr";
            this.lblCopyr.Size = new System.Drawing.Size(400, 40);
            this.lblCopyr.TabIndex = 5;
            this.lblCopyr.Text = "© 2021 NEXEN Tire s.r.o., All rights reserved.";
            this.lblCopyr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestriction
            // 
            this.lblRestriction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRestriction.ForeColor = System.Drawing.Color.White;
            this.lblRestriction.Location = new System.Drawing.Point(12, 92);
            this.lblRestriction.Name = "lblRestriction";
            this.lblRestriction.Size = new System.Drawing.Size(400, 40);
            this.lblRestriction.TabIndex = 6;
            this.lblRestriction.Text = "This application only for Nexen Tire Czech.";
            this.lblRestriction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblCompanyWebsite
            // 
            this.llblCompanyWebsite.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llblCompanyWebsite.AutoSize = true;
            this.llblCompanyWebsite.LinkColor = System.Drawing.Color.White;
            this.llblCompanyWebsite.Location = new System.Drawing.Point(148, 132);
            this.llblCompanyWebsite.Name = "llblCompanyWebsite";
            this.llblCompanyWebsite.Size = new System.Drawing.Size(104, 15);
            this.llblCompanyWebsite.TabIndex = 8;
            this.llblCompanyWebsite.TabStop = true;
            this.llblCompanyWebsite.Text = "Company Website";
            this.llblCompanyWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblCompanyWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AboutApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(424, 932);
            this.Controls.Add(this.llblCompanyWebsite);
            this.Controls.Add(this.lblRestriction);
            this.Controls.Add(this.lblCopyr);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCopyr;
        private System.Windows.Forms.Label lblRestriction;
        private System.Windows.Forms.LinkLabel llblCompanyWebsite;
    }
}