using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using User_Administration__For_VI_NMP_App_.Classes;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class AboutApp : Form
    {
        public AboutApp()
        {
            InitializeComponent();

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                lblTitle.Text = "Správa Databáze Vizuální Kontroly";
                lblVersion.Text = "Verze Aplikace: 1.1.2";
                lblRestriction.Text = "Tato aplikace je pouze pro Nexen Tire Czech.";
                llblCompanyWebsite.Text = "ODKAZ: Stránky Společnosti";
                lblCreator.Text = "Vývojář: Petr Staněk";
                lblEmail.Text = "Email: petr.stanek@nexentire.com";
                lblTel.Text = "Tel: +420 703 496 310";
                lblCopyr.Text = "© 2021 NEXEN Tire s.r.o., Všechna práva vyhrazena.";
            }
            else if (Translator.Language == Language.ENG)
            {
                lblTitle.Text = "Visual Inspection Database Administration";
                lblVersion.Text = "Application Version: 1.1.2";
                lblRestriction.Text = "This application only for Nexen Tire Czech.";
                llblCompanyWebsite.Text = "LINK: Company Website";
                lblCreator.Text = "Developer: Petr Staněk";
                lblEmail.Text = "Email: petr.stanek@nexentire.com";
                lblTel.Text = "Tel: +420 703 496 310";
                lblCopyr.Text = "© 2021 NEXEN Tire s.r.o., All rights reserved.";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.nexentire.com/cz/") { UseShellExecute = true });
        }
    }
}
