﻿using AnimalWeightTracker_00176727.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWeightTracker_00176727.Forms
{
    public partial class Form_Login : Form
    {
        //DataBase Connection
        DB_WeightTrackerEntities db = new DB_WeightTrackerEntities();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the application?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private bool mouseDown;
        //private int mouseX = 0, mouseY = 0;
        private Point _start_point = new Point(0, 0);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data = db.Staffs.Where(x => x.User_Name == txtUserName.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (data != null)
            {
                Form_Dashboard_AWT frm = new Form_Dashboard_AWT();
                this.Hide();
                frm.Show();
            }
            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "        Sorry, not a valid user...";
            }
            
        }

    }
}
