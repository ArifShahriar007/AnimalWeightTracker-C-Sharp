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
    public partial class Form_Staff : Form
    {
        //DataBase Connection
        Models.DB_WeightTrackerEntities db = new Models.DB_WeightTrackerEntities();

        public Form_Staff()
        {
            InitializeComponent();
        }

        private void btnStaffClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFOrgSrch_Click(object sender, EventArgs e)
        {
            Forms.Form_Org frmOrg = new Forms.Form_Org();
            frmOrg.ShowDialog();
        }

        private void Form_Staff_Load(object sender, EventArgs e)
        {
            var orgDataFK = db.Organizations.ToList();
            cmbStaffOrg.DataSource = orgDataFK;
            cmbStaffOrg.DisplayMember = "Name";
            cmbStaffOrg.ValueMember = "Org_Id";
        }

        private void btnStaffSave_Click(object sender, EventArgs e)
        {
            Models.Staff stf = new Models.Staff();
            stf.Name = txtStaffName.Text;
            stf.Date_Of_Birth = DateTime.Parse(dtStaffDOB.Text);
            stf.Gender = cmbStaffGender.Text;
            stf.Org_Id = Int32.Parse(cmbStaffOrg.SelectedValue.ToString());
            stf.Role = cmbStaffRole.Text;
            stf.Email = txtStaffEmail.Text;
            stf.User_Name = txtStaffUName.Text;
            stf.Password = txtStaffPWord.Text;

            db.Staffs.Add(stf);
            db.SaveChanges();

            txtStaffId.Text = stf.Staff_Id.ToString();

            MessageBox.Show("Data Saved Successfully ...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
