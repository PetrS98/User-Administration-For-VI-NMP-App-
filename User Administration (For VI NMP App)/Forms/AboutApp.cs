using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace User_Administration__For_VI_NMP_App_.Forms
{
    public partial class AboutApp : Form
    {
        public AboutApp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.nexentire.com/cz/") { UseShellExecute = true });
        }
    }
}
