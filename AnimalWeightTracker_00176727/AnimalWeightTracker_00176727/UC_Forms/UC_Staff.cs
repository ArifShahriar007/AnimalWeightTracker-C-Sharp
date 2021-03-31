using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalWeightTracker_00176727.Forms;

namespace AnimalWeightTracker_00176727.UC_Forms
{
    public partial class UC_Staff : UserControl
    {
        //DataBase Connection
        Models.DB_WeightTrackerEntities db = new Models.DB_WeightTrackerEntities();

        public UC_Staff()
        {
            InitializeComponent();
        }

        private void UC_Staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var stfData = db.Staffs.Select(d => new { d.Staff_Id, d.Name, d.Date_Of_Birth, d.Gender, d.Org_Id, d.Role, d.Email, d.User_Name, d.Password }).ToList();
            var orgData = db.Organizations.Select(d => new { d.Org_Id, d.Name, d.Address, d.Org_Type_Id }).ToList();
            var orgTypeData = db.OrganizationTypes.Select(d => new { d.Org_Type_Id, d.Org_Type }).ToList();

            dgvStaff.DataSource = stfData;
            dgvOrg.DataSource = orgData;
            dgvOrgType.DataSource = orgTypeData;

            lblStaffTotal.Text = stfData.Count.ToString();
            lblOrgTotal.Text = orgData.Count.ToString();
            lblOrgTypeTotal.Text = orgTypeData.Count.ToString();

            var orgDataFK = db.Organizations.ToList();
            cmbStaffOrg.DataSource = orgDataFK;
            cmbStaffOrg.DisplayMember = "Name";
            cmbStaffOrg.ValueMember = "Org_Id";

            var orgTypeFK = db.OrganizationTypes.ToList();
            cmbOrgTypeFK.DataSource = orgTypeFK;
            cmbOrgTypeFK.DisplayMember = "Org_Type";
            cmbOrgTypeFK.ValueMember = "Org_Type_Id";
        }

        private void btnStaffInsert_Click(object sender, EventArgs e)
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

            LoadData();

            MessageBox.Show("Data Inserted Successfully ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtStaffId.Text = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtStaffName.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtStaffDOB.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbStaffGender.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbStaffOrg.SelectedValue = dgvStaff.Rows[e.RowIndex].Cells[4].Value;
                cmbStaffRole.Text = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtStaffEmail.Text = dgvStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtStaffUName.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtStaffPWord.Text = dgvStaff.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnStaffReset_Click(object sender, EventArgs e)
        {
            txtStaffId.Text = "";
            txtStaffName.Text = "";
            dtStaffDOB.Text = "";
            cmbStaffGender.Text = "";
            cmbStaffOrg.SelectedIndex = 0;
            cmbStaffRole.Text = "";
            txtStaffEmail.Text = "";
            txtStaffUName.Text = "";
            txtStaffPWord.Text = "";
        }

        private void btnStaffUpdate_Click(object sender, EventArgs e)
        {
            int stfId = Int32.Parse(txtStaffId.Text);
            var stfData = db.Staffs.Where(d => d.Staff_Id == stfId).FirstOrDefault();

            if (stfData != null)
            {
                stfData.Name = txtStaffName.Text;
                stfData.Date_Of_Birth = DateTime.Parse(dtStaffDOB.Text);
                stfData.Gender = cmbStaffGender.Text;
                stfData.Org_Id = Int32.Parse(cmbStaffOrg.SelectedValue.ToString());
                stfData.Role = cmbStaffRole.Text;
                stfData.Email = txtStaffEmail.Text;
                stfData.User_Name = txtStaffUName.Text;
                stfData.Password = txtStaffPWord.Text;

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Data Updated Successfully ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            int stfId = Int32.Parse(txtStaffId.Text);
            var stfData = db.Staffs.Where(d => d.Staff_Id == stfId).FirstOrDefault();

            if (stfData != null)
            {
                db.Staffs.Remove(stfData);
                db.SaveChanges();

                LoadData();
            }
        }

        private void btnStaffSrch_Click(object sender, EventArgs e)
        {
            if (cmbStaffSrchBy.SelectedIndex == 0)
            {
                try
                {
                    int stfId = Int32.Parse(txtStaffId.Text);
                    var stfData = db.Staffs.Where(d => d.Staff_Id == stfId).Select(d => new { d.Staff_Id, d.Name, d.Date_Of_Birth, d.Gender, d.Org_Id, d.Role, d.Email, d.User_Name, d.Password }).ToList();

                    dgvStaff.DataSource = stfData;
                }
                catch (Exception)
                {

                }
            }

            if (cmbStaffSrchBy.SelectedIndex == 1)
            {
                var stfData = db.Staffs.Where(d => d.Name.Contains(txtStaffSrch.Text)).Select(d => new { d.Staff_Id, d.Name, d.Date_Of_Birth, d.Gender, d.Org_Id, d.Role, d.Email, d.User_Name, d.Password }).ToList();

                dgvStaff.DataSource = stfData;
            }

            if (cmbStaffSrchBy.SelectedIndex == 2)
            {
                var stfData = db.Staffs.Where(d => d.Email.Contains(txtStaffSrch.Text)).Select(d => new { d.Staff_Id, d.Name, d.Date_Of_Birth, d.Gender, d.Org_Id, d.Role, d.Email, d.User_Name, d.Password}).ToList();

                dgvStaff.DataSource = stfData;
            }
        }

        private void btnOrgInsert_Click(object sender, EventArgs e)
        {
            Models.Organization org = new Models.Organization();
            org.Name = txtOrgName.Text;
            org.Address = txtOrgAddress.Text;
            org.Org_Type_Id = Int32.Parse(cmbOrgTypeFK.SelectedValue.ToString());

            db.Organizations.Add(org);
            db.SaveChanges();

            txtOrgId.Text = org.Org_Id.ToString();

            LoadData();

            MessageBox.Show("Data Inserted Successfully ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOrgId.Text = dgvOrg.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtOrgName.Text = dgvOrg.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtOrgAddress.Text = dgvOrg.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbOrgTypeFK.SelectedValue = dgvOrg.Rows[e.RowIndex].Cells[3].Value;
            }
            catch (Exception)
            {

            }
        }

        private void btnOrgReset_Click(object sender, EventArgs e)
        {
            txtOrgId.Text = "";
            txtOrgName.Text = "";
            txtOrgAddress.Text = "";
            cmbOrgTypeFK.SelectedIndex = 0;
        }

        private void btnOrgUpdate_Click(object sender, EventArgs e)
        {
            int orgId = Int32.Parse(txtOrgId.Text);
            var orgData = db.Organizations.Where(d => d.Org_Id == orgId).FirstOrDefault();

            if (orgData != null)
            {
                orgData.Name = txtOrgName.Text;
                orgData.Address = txtOrgAddress.Text;
                orgData.Org_Type_Id = Int32.Parse(cmbOrgTypeFK.SelectedValue.ToString());

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Data Updated Successfully ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrgDelete_Click(object sender, EventArgs e)
        {
            int orgId = Int32.Parse(txtOrgId.Text);
            var orgData = db.Organizations.Where(d => d.Org_Id == orgId).FirstOrDefault();

            if (orgData != null)
            {
                db.Organizations.Remove(orgData);
                db.SaveChanges();

                LoadData();
            }
        }

        private void btnOrgSrch_Click(object sender, EventArgs e)
        {
            if (cmbOrgSrchBy.SelectedIndex == 0)
            {
                try
                {
                    int orgId = Int32.Parse(txtOrgId.Text);
                    var orgData = db.Organizations.Where(d => d.Org_Id == orgId).Select(d => new { d.Org_Id, d.Name, d.Address, d.Org_Type_Id }).ToList();

                    dgvOrg.DataSource = orgData;
                }
                catch (Exception)
                {

                }
            }

            if (cmbOrgSrchBy.SelectedIndex == 1)
            {
                var orgData = db.Organizations.Where(d => d.Name.Contains(txtOrgSrch.Text)).Select(d => new { d.Org_Id, d.Name, d.Address, d.Org_Type_Id }).ToList();

                dgvOrg.DataSource = orgData;
            }
        }

        private void btnOrgTypeInsert_Click(object sender, EventArgs e)
        {
            Models.OrganizationType orgType = new Models.OrganizationType();
            orgType.Org_Type = txtOrgType.Text;

            db.OrganizationTypes.Add(orgType);
            db.SaveChanges();

            txtOrgTypeId.Text = orgType.Org_Type_Id.ToString();

            LoadData();

            MessageBox.Show("Data Inserted Successfully ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvOrgType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOrgTypeId.Text = dgvOrgType.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtOrgType.Text = dgvOrgType.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnOrgTypeReset_Click(object sender, EventArgs e)
        {
            txtOrgTypeId.Text = "";
            txtOrgType.Text = "";
        }

        private void btnOrgTypeUpdate_Click(object sender, EventArgs e)
        {
            int orgTypeId = Int32.Parse(txtOrgTypeId.Text);
            var orgTypeData = db.OrganizationTypes.Where(d => d.Org_Type_Id == orgTypeId).FirstOrDefault();

            if (orgTypeData != null)
            {
                orgTypeData.Org_Type = txtOrgType.Text;

                db.SaveChanges();

                LoadData();
            }
        }

        private void btnOrgTypeDelete_Click(object sender, EventArgs e)
        {
            int orgTypeId = Int32.Parse(txtOrgTypeId.Text);
            var orgTypeData = db.OrganizationTypes.Where(d => d.Org_Type_Id == orgTypeId).FirstOrDefault();

            if (orgTypeData != null)
            {
                db.OrganizationTypes.Remove(orgTypeData);
                db.SaveChanges();

                LoadData();
            }
        }

        private void btnOrgTypeSrch_Click(object sender, EventArgs e)
        {
            if (cmbOrgSrchBy.SelectedIndex == 0)
            {
                try
                {
                    int orgTypeId = Int32.Parse(txtOrgTypeId.Text);
                    var orgTypeData = db.OrganizationTypes.Where(d => d.Org_Type_Id == orgTypeId).Select(d => new { d.Org_Type_Id, d.Org_Type }).ToList();

                    dgvOrgType.DataSource = orgTypeData;
                }
                catch (Exception)
                {

                }
            }

            if (cmbOrgSrchBy.SelectedIndex == 1)
            {
                var orgTypeData = db.OrganizationTypes.Where(d => d.Org_Type.Contains(txtOrgTypeSrch.Text)).Select(d => new { d.Org_Type_Id, d.Org_Type }).ToList();

                dgvOrgType.DataSource = orgTypeData;
            }
        }

        private void btnFOrgTypeSrch_Click(object sender, EventArgs e)
        {
            Forms.Form_OrgType frmOrgType = new Forms.Form_OrgType();
            frmOrgType.ShowDialog();
        }

        private void btnFOrgSrch_Click(object sender, EventArgs e)
        {
            Forms.Form_Org frmOrg = new Forms.Form_Org();
            frmOrg.ShowDialog();
        }
    }
}
