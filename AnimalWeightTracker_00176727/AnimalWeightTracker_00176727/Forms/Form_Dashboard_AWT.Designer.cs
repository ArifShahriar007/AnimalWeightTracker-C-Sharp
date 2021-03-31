namespace AnimalWeightTracker_00176727.Forms
{
    partial class Form_Dashboard_AWT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard_AWT));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuSelected = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnDailyRecords = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAWT = new System.Windows.Forms.Label();
            this.ptrLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlUCMain = new System.Windows.Forms.Panel();
            this.uC_Home1 = new AnimalWeightTracker_00176727.UC_Forms.UC_Home();
            this.uC_Reports1 = new AnimalWeightTracker_00176727.UC_Forms.UC_Reports();
            this.uC_Charts1 = new AnimalWeightTracker_00176727.UC_Forms.UC_Charts();
            this.uC_DailyRecords1 = new AnimalWeightTracker_00176727.UC_Forms.UC_DailyRecords();
            this.uC_Animal1 = new AnimalWeightTracker_00176727.UC_Forms.UC_Animal();
            this.uC_Staff1 = new AnimalWeightTracker_00176727.UC_Forms.UC_Staff();
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).BeginInit();
            this.pnlUCMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.pnlMenu.Controls.Add(this.pnlMenuSelected);
            this.pnlMenu.Controls.Add(this.btnStaff);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnCharts);
            this.pnlMenu.Controls.Add(this.btnDailyRecords);
            this.pnlMenu.Controls.Add(this.btnAnimal);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(175, 680);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlMenuSelected
            // 
            this.pnlMenuSelected.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenuSelected.Location = new System.Drawing.Point(0, 62);
            this.pnlMenuSelected.Name = "pnlMenuSelected";
            this.pnlMenuSelected.Size = new System.Drawing.Size(10, 55);
            this.pnlMenuSelected.TabIndex = 3;
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(10, 347);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(165, 55);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "    Staff";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(10, 290);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(165, 55);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "    Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(0, 625);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(55, 55);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.FlatAppearance.BorderSize = 0;
            this.btnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharts.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCharts.Image = ((System.Drawing.Image)(resources.GetObject("btnCharts.Image")));
            this.btnCharts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCharts.Location = new System.Drawing.Point(10, 233);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(165, 55);
            this.btnCharts.TabIndex = 3;
            this.btnCharts.Text = "    Charts";
            this.btnCharts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCharts.UseVisualStyleBackColor = true;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // btnDailyRecords
            // 
            this.btnDailyRecords.FlatAppearance.BorderSize = 0;
            this.btnDailyRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyRecords.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDailyRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnDailyRecords.Image")));
            this.btnDailyRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailyRecords.Location = new System.Drawing.Point(10, 176);
            this.btnDailyRecords.Name = "btnDailyRecords";
            this.btnDailyRecords.Size = new System.Drawing.Size(165, 55);
            this.btnDailyRecords.TabIndex = 2;
            this.btnDailyRecords.Text = "    Daily Records";
            this.btnDailyRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDailyRecords.UseVisualStyleBackColor = true;
            this.btnDailyRecords.Click += new System.EventHandler(this.btnDailyRecords_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.FlatAppearance.BorderSize = 0;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimal.Image")));
            this.btnAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimal.Location = new System.Drawing.Point(10, 119);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(165, 55);
            this.btnAnimal.TabIndex = 1;
            this.btnAnimal.Text = "    Animal";
            this.btnAnimal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 62);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 55);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "    Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Location = new System.Drawing.Point(175, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1125, 30);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Window;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1041, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1083, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlLogo.Controls.Add(this.lblAWT);
            this.pnlLogo.Controls.Add(this.ptrLogo);
            this.pnlLogo.Location = new System.Drawing.Point(235, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(133, 151);
            this.pnlLogo.TabIndex = 2;
            // 
            // lblAWT
            // 
            this.lblAWT.AutoSize = true;
            this.lblAWT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAWT.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAWT.Location = new System.Drawing.Point(3, 118);
            this.lblAWT.Name = "lblAWT";
            this.lblAWT.Size = new System.Drawing.Size(127, 15);
            this.lblAWT.TabIndex = 3;
            this.lblAWT.Text = "Animal Weight Tracker";
            // 
            // ptrLogo
            // 
            this.ptrLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptrLogo.Image")));
            this.ptrLogo.Location = new System.Drawing.Point(32, 32);
            this.ptrLogo.Name = "ptrLogo";
            this.ptrLogo.Size = new System.Drawing.Size(73, 73);
            this.ptrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrLogo.TabIndex = 0;
            this.ptrLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(374, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 23);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Ahsania Cattle And Dairy Farm";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitle.Location = new System.Drawing.Point(175, 31);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1125, 135);
            this.pnlTitle.TabIndex = 4;
            // 
            // pnlUCMain
            // 
            this.pnlUCMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUCMain.Controls.Add(this.uC_Home1);
            this.pnlUCMain.Controls.Add(this.uC_Reports1);
            this.pnlUCMain.Controls.Add(this.uC_Charts1);
            this.pnlUCMain.Controls.Add(this.uC_DailyRecords1);
            this.pnlUCMain.Controls.Add(this.uC_Animal1);
            this.pnlUCMain.Controls.Add(this.uC_Staff1);
            this.pnlUCMain.Location = new System.Drawing.Point(175, 165);
            this.pnlUCMain.Name = "pnlUCMain";
            this.pnlUCMain.Size = new System.Drawing.Size(1125, 515);
            this.pnlUCMain.TabIndex = 5;
            // 
            // uC_Home1
            // 
            this.uC_Home1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Home1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Home1.Location = new System.Drawing.Point(0, 0);
            this.uC_Home1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1125, 515);
            this.uC_Home1.TabIndex = 6;
            // 
            // uC_Reports1
            // 
            this.uC_Reports1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Reports1.AutoScroll = true;
            this.uC_Reports1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Reports1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reports1.Name = "uC_Reports1";
            this.uC_Reports1.Size = new System.Drawing.Size(1125, 515);
            this.uC_Reports1.TabIndex = 5;
            // 
            // uC_Charts1
            // 
            this.uC_Charts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Charts1.AutoScroll = true;
            this.uC_Charts1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Charts1.Location = new System.Drawing.Point(0, 0);
            this.uC_Charts1.Name = "uC_Charts1";
            this.uC_Charts1.Size = new System.Drawing.Size(1125, 515);
            this.uC_Charts1.TabIndex = 4;
            // 
            // uC_DailyRecords1
            // 
            this.uC_DailyRecords1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_DailyRecords1.AutoScroll = true;
            this.uC_DailyRecords1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_DailyRecords1.Location = new System.Drawing.Point(0, 0);
            this.uC_DailyRecords1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_DailyRecords1.Name = "uC_DailyRecords1";
            this.uC_DailyRecords1.Size = new System.Drawing.Size(1125, 515);
            this.uC_DailyRecords1.TabIndex = 2;
            // 
            // uC_Animal1
            // 
            this.uC_Animal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Animal1.AutoScroll = true;
            this.uC_Animal1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Animal1.Location = new System.Drawing.Point(0, 0);
            this.uC_Animal1.Name = "uC_Animal1";
            this.uC_Animal1.Size = new System.Drawing.Size(1125, 515);
            this.uC_Animal1.TabIndex = 0;
            // 
            // uC_Staff1
            // 
            this.uC_Staff1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Staff1.AutoScroll = true;
            this.uC_Staff1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Staff1.Location = new System.Drawing.Point(0, 0);
            this.uC_Staff1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_Staff1.Name = "uC_Staff1";
            this.uC_Staff1.Size = new System.Drawing.Size(1125, 515);
            this.uC_Staff1.TabIndex = 3;
            // 
            // Form_Dashboard_AWT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 680);
            this.Controls.Add(this.pnlUCMain);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Form_Dashboard_AWT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard_AWT";
            this.Load += new System.EventHandler(this.Form_Dashboard_AWT_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).EndInit();
            this.pnlUCMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox ptrLogo;
        private System.Windows.Forms.Label lblAWT;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.Button btnDailyRecords;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlMenuSelected;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlUCMain;
        private UC_Forms.UC_Animal uC_Animal1;
        private UC_Forms.UC_DailyRecords uC_DailyRecords1;
        private UC_Forms.UC_Staff uC_Staff1;
        private UC_Forms.UC_Reports uC_Reports1;
        private UC_Forms.UC_Charts uC_Charts1;
        private UC_Forms.UC_Home uC_Home1;
    }
}