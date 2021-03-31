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
    public partial class Form_OrgType : Form
    {
        //DataBase Connection
        Models.DB_WeightTrackerEntities db = new Models.DB_WeightTrackerEntities();

        public Form_OrgType()
        {
            InitializeComponent();
        }

        private void btnOrgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrgTypeSave_Click(object sender, EventArgs e)
        {
            Models.OrganizationType orgType = new Models.OrganizationType();
            orgType.Org_Type = txtOrgType.Text;

            db.OrganizationTypes.Add(orgType);
            db.SaveChanges();

            txtOrgTypeId.Text = orgType.Org_Type_Id.ToString();

            MessageBox.Show("Data Saved Successfully ...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
