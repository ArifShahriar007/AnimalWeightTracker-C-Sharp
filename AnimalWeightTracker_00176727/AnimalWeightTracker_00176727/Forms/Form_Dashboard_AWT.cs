using AnimalWeightTracker_00176727.Models;
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
    public partial class Form_Dashboard_AWT : Form
    {
        //DataBase Connection
        //DB_WeightTrackerEntities db = new DB_WeightTrackerEntities();

        public Form_Dashboard_AWT()
        {
            InitializeComponent();
            pnlMenuSelected.Height = btnHome.Height;
            pnlMenuSelected.Top = btnHome.Top;
            uC_Home1.BringToFront();
        }

        private void Form_Dashboard_AWT_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Ahsania Cattle And Dairy Farm | " + DateTime.Now.ToLongDateString();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMenuSelected.Height = btnHome.Height;
            pnlMenuSelected.Top = btnHome.Top;
            uC_Home1.BringToFront();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            pnlMenuSelected.Height = btnAnimal.Height;
            pnlMenuSelected.Top = btnAnimal.Top;
            uC_Animal1.BringToFront();
        }

        private void btnDailyRecords_Click(object sender, EventArgs e)
        {
            pnlMenuSelected.Height = btnDailyRecords.Height;
            pnlMenuSelected.Top = btnDailyRecords.Top;
            uC_DailyRecords1.BringToFront();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            pnlMenuSelected.Height = btnCharts.Height;
            pnlMenuSelected.Top = btnCharts.Top;
            uC_Charts1.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlMenuSelected.Height = btnReports.Height;
            pnlMenuSelected.Top = btnReports.Top;
            uC_Reports1.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnlMenuSelected.Height = btnStaff.Height;
            pnlMenuSelected.Top = btnStaff.Top;
            uC_Staff1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form_Login frm = new Form_Login();
                this.Hide();
                frm.Show();
            }
        }

    }
}
