﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace User_Administration__For_VI_NMP_App_.Forms.MessageBoxes
{
    public partial class CustomMessageBox_Yes_No : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public CustomMessageBox_Yes_No()
        {
            InitializeComponent();
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

        public static DialogResult ShowPopup(string Title, string Message)
        {
            var messagebox = new CustomMessageBox_Yes_No();

            messagebox.lblTitle.Text = Title;
            messagebox.lblInfoText.Text = Message;

            return messagebox.ShowDialog();
        }
    }
}
