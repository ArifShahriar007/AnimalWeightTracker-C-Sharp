using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWeightTracker_00176727.UC_Forms
{
    public partial class UC_DailyRecords : UserControl
    {

        //DataBase Connection
        Models.DB_WeightTrackerEntities db = new Models.DB_WeightTrackerEntities();

        public UC_DailyRecords()
        {
            InitializeComponent();
        }

        private void UC_DailyRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var dLogData = db.Daily_Log.Select(d => new { d.Daily_Log_Id, d.Course_Id, d.Activity_Id, d.Date, d.Progress }).ToList();
            var dMealData = db.Daily_Meal.Select(d => new { d.Daily_Meal_Id, d.Daily_Log_Id, d.Meal_Id, d.Meal_Intake }).ToList();
            var dExrData = db.Daily_Exercise.Select(d => new { d.Daily_Exr_Id, d.Daily_Log_Id, d.Exr_Id, d.Duration }).ToList();
            var dMsrData = db.Daily_Measurement.Select(d => new { d.Daily_Msr_Id, d.Daily_Log_Id, d.Waist_Size, d.Weight, d.Shift }).ToList();

            dgvDLog.DataSource = dLogData;
            dgvDMeal.DataSource = dMealData;
            dgvDExr.DataSource = dExrData;
            dgvDMsr.DataSource = dMsrData;

            lblDLogTotal.Text = dLogData.Count.ToString();
            lblDMealTotal.Text = dMealData.Count.ToString();
            lblDExrTotal.Text = dExrData.Count.ToString();
            lblDMsrTotal.Text = dMsrData.Count.ToString();

            var dLogCrs = db.Courses.ToList();
            cmbDLogCourse.DataSource = dLogCrs;
            cmbDLogCourse.DisplayMember = "Name";
            cmbDLogCourse.ValueMember = "Course_Id";

            var dLogAct = db.Activities.ToList();
            cmbDLogActivity.DataSource = dLogAct;
            cmbDLogActivity.DisplayMember = "Level";
            cmbDLogActivity.ValueMember = "Activity_Id";

            var dMlLogDate = db.Daily_Log.ToList();
            cmbDMealLogDate.DataSource = dMlLogDate;
            cmbDMealLogDate.DisplayMember = "Date";
            cmbDMealLogDate.ValueMember = "Daily_Log_Id";

            var dExrLogDate = db.Daily_Log.ToList();
            cmbDExrLogDate.DataSource = dExrLogDate;
            cmbDExrLogDate.DisplayMember = "Date";
            cmbDExrLogDate.ValueMember = "Daily_Log_Id";

            var dMsrLogDate = db.Daily_Log.ToList();
            cmbDMsrLogDate.DataSource = dMsrLogDate;
            cmbDMsrLogDate.DisplayMember = "Date";
            cmbDMsrLogDate.ValueMember = "Daily_Log_Id";

            var dMl = db.Meals.ToList();
            cmbDMeal.DataSource = dMl;
            cmbDMeal.DisplayMember = "Name";
            cmbDMeal.ValueMember = "Meal_Id";

            var dExrType = db.Exercises.ToList();
            cmbDExrType.DataSource = dExrType;
            cmbDExrType.DisplayMember = "Type";
            cmbDExrType.ValueMember = "Exr_Id";
        }

        private void btnDLogInsert_Click(object sender, EventArgs e)
        {
            Models.Daily_Log dLog = new Models.Daily_Log();
            dLog.Course_Id = Int32.Parse(cmbDLogCourse.SelectedValue.ToString());
            dLog.Activity_Id = Int32.Parse(cmbDLogActivity.SelectedValue.ToString());
            dLog.Date = DateTime.Parse(dtDLogDate.Text);
            dLog.Progress = txtDLogProgress.Text;

            db.Daily_Log.Add(dLog);
            db.SaveChanges();

            txtDLogId.Text = dLog.Daily_Log_Id.ToString();

            LoadData();

            MessageBox.Show("Data Inserted Successfully ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDLogId.Text = dgvDLog.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbDLogCourse.SelectedValue = dgvDLog.Rows[e.RowIndex].Cells[1].Value;
                cmbDLogActivity.SelectedValue = dgvDLog.Rows[e.RowIndex].Cells[2].Value;
                dtDLogDate.Text = dgvDLog.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDLogProgress.Text = dgvDLog.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDLogReset_Click(object sender, EventArgs e)
        {
            txtDLogId.Text = "";
            cmbDLogCourse.SelectedIndex = 0;
            cmbDLogActivity.SelectedIndex = 0;
            dtDLogDate.Text = "";
            txtDLogProgress.Text = "";
        }

        private void btnDLogUpdate_Click(object sender, EventArgs e)
        {
            int dLogId = Int32.Parse(txtDLogId.Text);
            var dLogData = db.Daily_Log.Where(d => d.Daily_Log_Id == dLogId).FirstOrDefault();

            if (dLogData != null)
            {
                dLogData.Course_Id = Int32.Parse(cmbDLogCourse.SelectedValue.ToString());
                dLogData.Activity_Id = Int32.Parse(cmbDLogActivity.SelectedValue.ToString());
                dLogData.Date = DateTime.Parse(dtDLogDate.Text);
                dLogData.Progress = txtDLogProgress.Text;

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Data Updated Successfully ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDLogDelete_Click(object sender, EventArgs e)
        {
            int dLogId = Int32.Parse(txtDLogId.Text);
            var dLogData = db.Daily_Log.Where(d => d.Daily_Log_Id == dLogId).FirstOrDefault();

            if (dLogData != null)
            {
                db.Daily_Log.Remove(dLogData);
                db.SaveChanges();

                LoadData();
            }
        }

        private void btnDLogSrch_Click(object sender, EventArgs e)
        {
            if (cmbDLogSrchBy.SelectedIndex == 0)
            {
                try
                {
                    int dLogId = Int32.Parse(txtDLogSrch.Text);
                    var dLogData = db.Daily_Log.Where(d => d.Daily_Log_Id == dLogId).Select(d => new { d.Daily_Log_Id, d.Course_Id, d.Activity_Id, d.Date, d.Progress }).ToList();

                    dgvDLog.DataSource = dLogData;
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnDMealInsert_Click(object sender, EventArgs e)
        {
            Models.Daily_Meal dMeal = new Models.Daily_Meal();
            dMeal.Daily_Log_Id = Int32.Parse(cmbDMealLogDate.SelectedValue.ToString());
            dMeal.Meal_Id = Int32.Parse(cmbDMeal.SelectedValue.ToString());
            dMeal.Meal_Intake = Int32.Parse(txtDMealIntake.Text);

            db.Daily_Meal.Add(dMeal);
            db.SaveChanges();

            txtDMealId.Text = dMeal.Daily_Meal_Id.ToString();

            LoadData();

            MessageBox.Show("Data Inserted Successfully ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDMeal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDMealId.Text = dgvDMeal.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbDMealLogDate.SelectedValue = dgvDMeal.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbDMeal.SelectedValue = dgvDMeal.Rows[e.RowIndex].Cells[2].Value;
                txtDMealIntake.Text = dgvDMeal.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDMealReset_Click(object sender, EventArgs e)
        {
            txtDMealId.Text = "";
            cmbDMealLogDate.SelectedIndex = 0;
            cmbDMeal.SelectedIndex = 0;
            txtDMealIntake.Text = "";
        }

        private void btnDMealUpdate_Click(object sender, EventArgs e)
        {
            int dMealId = Int32.Parse(txtDMealId.Text);
            var dMealData = db.Daily_Meal.Where(d => d.Daily_Meal_Id == dMealId).FirstOrDefault();

            if (dMealData != null)
            {
                dMealData.Daily_Log_Id = Int32.Parse(cmbDMealLogDate.SelectedValue.ToString());
                dMealData.Meal_Id = Int32.Parse(cmbDMeal.SelectedValue.ToString());
                dMealData.Meal_Intake = Int32.Parse(txtDMealIntake.Text);

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Data Updated Successfully ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDMealDelete_Click(object sender, EventArgs e)
        {
            int dMealId = Int32.Parse(txtDMealId.Text);
            var dMealData = db.Daily_Meal.Where(d => d.Daily_Meal_Id == dMealId).FirstOrDefault();

            if (dMealData != null)
            {
                db.Daily_Meal.Remove(dMealData);
                db.SaveChanges();

                LoadData();
            }
        }

        private void btnDMealSrch_Click(object sender, EventArgs e)
        {
            if (cmbDMealSrchBy.SelectedIndex == 0)
            {
                try
                {
                    int dMealId = Int32.Parse(txtDMealSrch.Text);
                    var dMealData = db.Daily_Meal.Where(d => d.Daily_Meal_Id == dMealId).Select(d => new { d.Daily_Meal_Id, d.Daily_Log_Id, d.Meal_Id, d.Meal_Intake }).ToList();

                    dgvDMeal.DataSource = dMealData;
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnDExrInsert_Click(object sender, EventArgs e)
        {
            Models.Daily_Exercise dExr = new Models.Daily_Exercise();
            dExr.Daily_Log_Id = Int32.Parse(cmbDExrLogDate.SelectedValue.ToString());
            dExr.Exr_Id = Int32.Parse(cmbDExrType.SelectedValue.ToString());
            dExr.Duration = Int32.Parse(txtDExrDuration.Text);

            db.Daily_Exercise.Add(dExr);
            db.SaveChanges();

            txtDExrId.Text = dExr.Daily_Exr_Id.ToString();

            LoadData();

            MessageBox.Show("Data Inserted Successfully ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDExr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDExrId.Text = dgvDExr.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbDExrLogDate.SelectedValue = dgvDExr.Rows[e.RowIndex].Cells[1].Value;
                cmbDExrType.SelectedValue = dgvDExr.Rows[e.RowIndex].Cells[2].Value;
                txtDExrDuration.Text = dgvDExr.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDExrReset_Click(object sender, EventArgs e)
        {
            txtDExrId.Text = "";
            cmbDExrLogDate.SelectedValue = 0;
            cmbDExrType.SelectedIndex = 0;
            txtDExrDuration.Text = "";
        }

        private void btnDExrUpdate_Click(object sender, EventArgs e)
        {
            int dExrId = Int32.Parse(txtDExrId.Text);
            var dExrData = db.Daily_Exercise.Where(d => d.Daily_Exr_Id == dExrId).FirstOrDefault();

            if (dExrData != null)
            {
                dExrData.Daily_Log_Id = Int32.Parse(cmbDExrLogDate.SelectedValue.ToString());
                dExrData.Exr_Id = Int32.Parse(cmbDExrType.SelectedValue.ToString());
                dExrData.Duration = Int32.Parse(txtDExrDuration.Text);

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Data Updated Successfully ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDExrDelete_Click(object sender, EventArgs e)
        {
            int dExrId = Int32.Parse(txtDExrId.Text);
            var dExrData = db.Daily_Exercise.Where(d => d.Daily_Exr_Id == dExrId).FirstOrDefault();

            if (dExrData != null)
            {
                db.Daily_Exercise.Remove(dExrData);
                db.SaveChanges();

                LoadData();
            }
        }

        private void btnDExrSrch_Click(object sender, EventArgs e)
        {
            if (cmbDExrSrchBy.SelectedIndex == 0)
            {
                try
                {
                    int dExrId = Int32.Parse(txtDExrSrch.Text);
                    var dExrData = db.Daily_Exercise.Where(d => d.Daily_Exr_Id == dExrId).Select(d => new { d.Daily_Exr_Id, d.Daily_Log_Id, d.Exr_Id, d.Duration }).ToList();

                    dgvDExr.DataSource = dExrData;
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnDMsrInsert_Click(object sender, EventArgs e)
        {
            Models.Daily_Measurement dMsr = new Models.Daily_Measurement();
            dMsr.Daily_Log_Id = Int32.Parse(cmbDMsrLogDate.SelectedValue.ToString());
            dMsr.Waist_Size = Decimal.Parse(txtDMsrDWaist.Text);
            dMsr.Weight = Decimal.Parse(txtDMsrDWeight.Text);
            dMsr.Shift = cmbDMsrShift.Text;

            db.Daily_Measurement.Add(dMsr);
            db.SaveChanges();

            txtDMsrId.Text = dMsr.Daily_Msr_Id.ToString();

            LoadData();

            MessageBox.Show("Data Inserted Successfully ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDMsr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDMsrId.Text = dgvDMsr.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbDMsrLogDate.SelectedValue = dgvDMsr.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDMsrDWaist.Text = dgvDMsr.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDMsrDWeight.Text = dgvDMsr.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbDMsrShift.SelectedValue = dgvDMsr.Rows[e.RowIndex].Cells[4].Value;
            }
            catch (Exception)
            {

            }
        }

        private void btnDMsrReset_Click(object sender, EventArgs e)
        {
            txtDMsrId.Text = "";
            cmbDMsrLogDate.SelectedIndex = 0;
            txtDMsrDWaist.Text = "";
            txtDMsrDWeight.Text = "";
            cmbDMsrShift.SelectedIndex = 0;
        }

        private void btnDMsrUpdate_Click(object sender, EventArgs e)
        {
            int dMsrId = Int32.Parse(txtDMsrId.Text);
            var dMsrData = db.Daily_Measurement.Where(d => d.Daily_Msr_Id == dMsrId).FirstOrDefault();

            if (dMsrData != null)
            {
                dMsrData.Daily_Log_Id = Int32.Parse(cmbDMsrLogDate.SelectedValue.ToString());
                dMsrData.Waist_Size = decimal.Parse(txtDMsrDWaist.Text);
                dMsrData.Weight = decimal.Parse(txtDMsrDWeight.Text);
                dMsrData.Shift = cmbDMsrShift.Text;

                db.SaveChanges();

                LoadData();

                MessageBox.Show("Data Updated Successfully ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDMsrDelete_Click(object sender, EventArgs e)
        {
            int dMsrId = Int32.Parse(txtDMsrId.Text);
            var dMsrData = db.Daily_Measurement.Where(d => d.Daily_Msr_Id == dMsrId).FirstOrDefault();

            if (dMsrData != null)
            {
                db.Daily_Measurement.Remove(dMsrData);
                db.SaveChanges();

                LoadData();
            }
        }

        private void btnDMsrSrch_Click(object sender, EventArgs e)
        {
            if (cmbDMsrSrchBy.SelectedIndex == 0)
            {
                try
                {
                    int dMsrId = Int32.Parse(txtDMsrSrch.Text);
                    var dMsrData = db.Daily_Measurement.Where(d => d.Daily_Msr_Id == dMsrId).Select(d => new { d.Daily_Msr_Id, d.Daily_Log_Id, d.Waist_Size, d.Weight, d.Shift }).ToList();

                    dgvDMsr.DataSource = dMsrData;
                }
                catch (Exception)
                {

                }
            }
            if (cmbDMsrSrchBy.SelectedIndex == 1)
            {
                var dMsrData = db.Daily_Measurement.Where(d => d.Shift.Contains(txtDMsrSrch.Text)).Select(d => new { d.Daily_Msr_Id, d.Daily_Log_Id, d.Waist_Size, d.Weight, d.Shift }).ToList();

                dgvDMsr.DataSource = dMsrData;
            }
        }
    }
}
