namespace AnimalWeightTracker_00176727.Forms
{
    partial class Form_Org
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Org));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOrg = new System.Windows.Forms.GroupBox();
            this.btnFOrgTypeSrch = new System.Windows.Forms.Button();
            this.cmbOrgTypeFK = new System.Windows.Forms.ComboBox();
            this.txtOrgAddress = new System.Windows.Forms.TextBox();
            this.lblOrgAddress = new System.Windows.Forms.Label();
            this.lblOrgTypeFK = new System.Windows.Forms.Label();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.txtOrgId = new System.Windows.Forms.TextBox();
            this.lblOrgId = new System.Windows.Forms.Label();
            this.btnOrgClose = new System.Windows.Forms.Button();
            this.btnOrgSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpOrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.grpOrg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 269);
            this.panel1.TabIndex = 0;
            // 
            // grpOrg
            // 
            this.grpOrg.Controls.Add(this.btnFOrgTypeSrch);
            this.grpOrg.Controls.Add(this.cmbOrgTypeFK);
            this.grpOrg.Controls.Add(this.txtOrgAddress);
            this.grpOrg.Controls.Add(this.lblOrgAddress);
            this.grpOrg.Controls.Add(this.lblOrgTypeFK);
            this.grpOrg.Controls.Add(this.txtOrgName);
            this.grpOrg.Controls.Add(this.lblOrgName);
            this.grpOrg.Controls.Add(this.txtOrgId);
            this.grpOrg.Controls.Add(this.lblOrgId);
            this.grpOrg.Controls.Add(this.btnOrgClose);
            this.grpOrg.Controls.Add(this.btnOrgSave);
            this.grpOrg.Location = new System.Drawing.Point(15, 15);
            this.grpOrg.Name = "grpOrg";
            this.grpOrg.Size = new System.Drawing.Size(639, 241);
            this.grpOrg.TabIndex = 1;
            this.grpOrg.TabStop = false;
            this.grpOrg.Text = "Organization";
            // 
            // btnFOrgTypeSrch
            // 
            this.btnFOrgTypeSrch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFOrgTypeSrch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFOrgTypeSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFOrgTypeSrch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFOrgTypeSrch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFOrgTypeSrch.Image = ((System.Drawing.Image)(resources.GetObject("btnFOrgTypeSrch.Image")));
            this.btnFOrgTypeSrch.Location = new System.Drawing.Point(577, 163);
            this.btnFOrgTypeSrch.Name = "btnFOrgTypeSrch";
            this.btnFOrgTypeSrch.Size = new System.Drawing.Size(25, 25);
            this.btnFOrgTypeSrch.TabIndex = 6;
            this.btnFOrgTypeSrch.UseVisualStyleBackColor = false;
            this.btnFOrgTypeSrch.Click += new System.EventHandler(this.btnFOrgTypeSrch_Click);
            // 
            // cmbOrgTypeFK
            // 
            this.cmbOrgTypeFK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOrgTypeFK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrgTypeFK.FormattingEnabled = true;
            this.cmbOrgTypeFK.Location = new System.Drawing.Point(128, 163);
            this.cmbOrgTypeFK.Name = "cmbOrgTypeFK";
            this.cmbOrgTypeFK.Size = new System.Drawing.Size(443, 25);
            this.cmbOrgTypeFK.TabIndex = 2;
            // 
            // txtOrgAddress
            // 
            this.txtOrgAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrgAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgAddress.Location = new System.Drawing.Point(128, 123);
            this.txtOrgAddress.Name = "txtOrgAddress";
            this.txtOrgAddress.Size = new System.Drawing.Size(443, 23);
            this.txtOrgAddress.TabIndex = 1;
            // 
            // lblOrgAddress
            // 
            this.lblOrgAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrgAddress.AutoSize = true;
            this.lblOrgAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgAddress.Location = new System.Drawing.Point(61, 126);
            this.lblOrgAddress.Name = "lblOrgAddress";
            this.lblOrgAddress.Size = new System.Drawing.Size(61, 17);
            this.lblOrgAddress.TabIndex = 185;
            this.lblOrgAddress.Text = "Address:";
            // 
            // lblOrgTypeFK
            // 
            this.lblOrgTypeFK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrgTypeFK.AutoSize = true;
            this.lblOrgTypeFK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgTypeFK.Location = new System.Drawing.Point(82, 167);
            this.lblOrgTypeFK.Name = "lblOrgTypeFK";
            this.lblOrgTypeFK.Size = new System.Drawing.Size(40, 17);
            this.lblOrgTypeFK.TabIndex = 184;
            this.lblOrgTypeFK.Text = "Type:";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrgName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgName.Location = new System.Drawing.Point(128, 83);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(443, 23);
            this.txtOrgName.TabIndex = 0;
            // 
            // lblOrgName
            // 
            this.lblOrgName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgName.Location = new System.Drawing.Point(70, 86);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(52, 17);
            this.lblOrgName.TabIndex = 183;
            this.lblOrgName.Text = "Name:";
            // 
            // txtOrgId
            // 
            this.txtOrgId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrgId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgId.Location = new System.Drawing.Point(128, 43);
            this.txtOrgId.Name = "txtOrgId";
            this.txtOrgId.ReadOnly = true;
            this.txtOrgId.Size = new System.Drawing.Size(443, 23);
            this.txtOrgId.TabIndex = 5;
            // 
            // lblOrgId
            // 
            this.lblOrgId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrgId.AutoSize = true;
            this.lblOrgId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgId.Location = new System.Drawing.Point(10, 46);
            this.lblOrgId.Name = "lblOrgId";
            this.lblOrgId.Size = new System.Drawing.Size(112, 17);
            this.lblOrgId.TabIndex = 186;
            this.lblOrgId.Text = "Organization Id:";
            // 
            // btnOrgClose
            // 
            this.btnOrgClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrgClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrgClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOrgClose.FlatAppearance.BorderSize = 2;
            this.btnOrgClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrgClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrgClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrgClose.Location = new System.Drawing.Point(356, 201);
            this.btnOrgClose.Name = "btnOrgClose";
            this.btnOrgClose.Size = new System.Drawing.Size(100, 30);
            this.btnOrgClose.TabIndex = 4;
            this.btnOrgClose.Text = "CLOSE";
            this.btnOrgClose.UseVisualStyleBackColor = false;
            this.btnOrgClose.Click += new System.EventHandler(this.btnOrgClose_Click);
            // 
            // btnOrgSave
            // 
            this.btnOrgSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrgSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrgSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOrgSave.FlatAppearance.BorderSize = 2;
            this.btnOrgSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrgSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrgSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrgSave.Location = new System.Drawing.Point(471, 201);
            this.btnOrgSave.Name = "btnOrgSave";
            this.btnOrgSave.Size = new System.Drawing.Size(100, 30);
            this.btnOrgSave.TabIndex = 3;
            this.btnOrgSave.Text = "SAVE";
            this.btnOrgSave.UseVisualStyleBackColor = false;
            this.btnOrgSave.Click += new System.EventHandler(this.btnOrgSave_Click);
            // 
            // Form_Org
            // 
            this.AcceptButton = this.btnOrgSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(685, 285);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Org";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Org";
            this.Load += new System.EventHandler(this.Form_Org_Load);
            this.panel1.ResumeLayout(false);
            this.grpOrg.ResumeLayout(false);
            this.grpOrg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpOrg;
        private System.Windows.Forms.Button btnOrgClose;
        private System.Windows.Forms.Button btnOrgSave;
        private System.Windows.Forms.Button btnFOrgTypeSrch;
        private System.Windows.Forms.ComboBox cmbOrgTypeFK;
        private System.Windows.Forms.TextBox txtOrgAddress;
        private System.Windows.Forms.Label lblOrgAddress;
        private System.Windows.Forms.Label lblOrgTypeFK;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.TextBox txtOrgId;
        private System.Windows.Forms.Label lblOrgId;
    }
}