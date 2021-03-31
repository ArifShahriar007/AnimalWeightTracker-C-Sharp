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
    public partial class Form_Animal : Form
    {
        //DataBase Connection
        Models.DB_WeightTrackerEntities db = new Models.DB_WeightTrackerEntities();

        public Form_Animal()
        {
            InitializeComponent();
        }

        private void btnAnimalClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFOrgSrch_Click(object sender, EventArgs e)
        {
            Forms.Form_Org frmOrg = new Forms.Form_Org();
            frmOrg.ShowDialog();
        }

        private void btnFSpeciesSrch_Click(object sender, EventArgs e)
        {
            Forms.Form_Species frmSps = new Forms.Form_Species();
            frmSps.ShowDialog();
        }

        private void Form_Animal_Load(object sender, EventArgs e)
        {
            var spDataFK = db.Species.ToList();
            cmbAnimalSpecies.DataSource = spDataFK;
            cmbAnimalSpecies.DisplayMember = "Name";
            cmbAnimalSpecies.ValueMember = "Species_Id";

            var orgDataFK = db.Organizations.ToList();
            cmbAnimalOrg.DataSource = orgDataFK;
            cmbAnimalOrg.DisplayMember = "Name";
            cmbAnimalOrg.ValueMember = "Org_Id";
        }

        private void btnAnimalSave_Click(object sender, EventArgs e)
        {
            Models.Animal ani = new Models.Animal();
            ani.Name = txtAnimalName.Text;
            ani.Age = txtAnimalAge.Text;
            ani.Gender = cmbAnimalGender.Text;
            ani.Height = decimal.Parse(txtAnimalHeight.Text);
            ani.Weight = decimal.Parse(txtAnimalWeight.Text);
            ani.Species_Id = Int32.Parse(cmbAnimalSpecies.SelectedValue.ToString());
            ani.Breed = txtAnimalBreed.Text;
            ani.Org_Id = Int32.Parse(cmbAnimalOrg.SelectedValue.ToString());

            db.Animals.Add(ani);
            db.SaveChanges();

            txtAnimalId.Text = ani.Animal_Id.ToString();

            MessageBox.Show("Data Saved Successfully ...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
