namespace AnimalWeightTracker_00176727.Forms
{
    partial class Form_Species
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSpecies = new System.Windows.Forms.GroupBox();
            this.btnSpeciesSave = new System.Windows.Forms.Button();
            this.txtSpeciesDes = new System.Windows.Forms.TextBox();
            this.txtSpeciesName = new System.Windows.Forms.TextBox();
            this.lblSpeciesName = new System.Windows.Forms.Label();
            this.txtSpeciesId = new System.Windows.Forms.TextBox();
            this.lblSpeciesId = new System.Windows.Forms.Label();
            this.btnSpeciesClose = new System.Windows.Forms.Button();
            this.lblSpeciesDes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpSpecies.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.grpSpecies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 269);
            this.panel1.TabIndex = 0;
            // 
            // grpSpecies
            // 
            this.grpSpecies.Controls.Add(this.btnSpeciesSave);
            this.grpSpecies.Controls.Add(this.txtSpeciesDes);
            this.grpSpecies.Controls.Add(this.txtSpeciesName);
            this.grpSpecies.Controls.Add(this.lblSpeciesName);
            this.grpSpecies.Controls.Add(this.txtSpeciesId);
            this.grpSpecies.Controls.Add(this.lblSpeciesId);
            this.grpSpecies.Controls.Add(this.btnSpeciesClose);
            this.grpSpecies.Controls.Add(this.lblSpeciesDes);
            this.grpSpecies.Location = new System.Drawing.Point(15, 15);
            this.grpSpecies.Name = "grpSpecies";
            this.grpSpecies.Size = new System.Drawing.Size(639, 241);
            this.grpSpecies.TabIndex = 1;
            this.grpSpecies.TabStop = false;
            this.grpSpecies.Text = "Species Info";
            // 
            // btnSpeciesSave
            // 
            this.btnSpeciesSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpeciesSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpeciesSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSpeciesSave.FlatAppearance.BorderSize = 2;
            this.btnSpeciesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeciesSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeciesSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpeciesSave.Location = new System.Drawing.Point(471, 201);
            this.btnSpeciesSave.Name = "btnSpeciesSave";
            this.btnSpeciesSave.Size = new System.Drawing.Size(100, 30);
            this.btnSpeciesSave.TabIndex = 2;
            this.btnSpeciesSave.Text = "SAVE";
            this.btnSpeciesSave.UseVisualStyleBackColor = false;
            this.btnSpeciesSave.Click += new System.EventHandler(this.btnSpeciesSave_Click);
            // 
            // txtSpeciesDes
            // 
            this.txtSpeciesDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeciesDes.Location = new System.Drawing.Point(128, 111);
            this.txtSpeciesDes.Multiline = true;
            this.txtSpeciesDes.Name = "txtSpeciesDes";
            this.txtSpeciesDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpeciesDes.Size = new System.Drawing.Size(443, 81);
            this.txtSpeciesDes.TabIndex = 1;
            // 
            // txtSpeciesName
            // 
            this.txtSpeciesName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeciesName.Location = new System.Drawing.Point(128, 76);
            this.txtSpeciesName.Name = "txtSpeciesName";
            this.txtSpeciesName.Size = new System.Drawing.Size(443, 23);
            this.txtSpeciesName.TabIndex = 0;
            // 
            // lblSpeciesName
            // 
            this.lblSpeciesName.AutoSize = true;
            this.lblSpeciesName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeciesName.Location = new System.Drawing.Point(70, 79);
            this.lblSpeciesName.Name = "lblSpeciesName";
            this.lblSpeciesName.Size = new System.Drawing.Size(52, 17);
            this.lblSpeciesName.TabIndex = 187;
            this.lblSpeciesName.Text = "Name:";
            // 
            // txtSpeciesId
            // 
            this.txtSpeciesId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeciesId.Location = new System.Drawing.Point(128, 43);
            this.txtSpeciesId.Name = "txtSpeciesId";
            this.txtSpeciesId.ReadOnly = true;
            this.txtSpeciesId.Size = new System.Drawing.Size(443, 23);
            this.txtSpeciesId.TabIndex = 4;
            // 
            // lblSpeciesId
            // 
            this.lblSpeciesId.AutoSize = true;
            this.lblSpeciesId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeciesId.Location = new System.Drawing.Point(47, 46);
            this.lblSpeciesId.Name = "lblSpeciesId";
            this.lblSpeciesId.Size = new System.Drawing.Size(75, 17);
            this.lblSpeciesId.TabIndex = 189;
            this.lblSpeciesId.Text = "Species Id:";
            // 
            // btnSpeciesClose
            // 
            this.btnSpeciesClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpeciesClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpeciesClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSpeciesClose.FlatAppearance.BorderSize = 2;
            this.btnSpeciesClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeciesClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeciesClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpeciesClose.Location = new System.Drawing.Point(356, 201);
            this.btnSpeciesClose.Name = "btnSpeciesClose";
            this.btnSpeciesClose.Size = new System.Drawing.Size(100, 30);
            this.btnSpeciesClose.TabIndex = 3;
            this.btnSpeciesClose.Text = "CLOSE";
            this.btnSpeciesClose.UseVisualStyleBackColor = false;
            this.btnSpeciesClose.Click += new System.EventHandler(this.btnSpeciesClose_Click);
            // 
            // lblSpeciesDes
            // 
            this.lblSpeciesDes.AutoSize = true;
            this.lblSpeciesDes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeciesDes.Location = new System.Drawing.Point(73, 115);
            this.lblSpeciesDes.Name = "lblSpeciesDes";
            this.lblSpeciesDes.Size = new System.Drawing.Size(49, 17);
            this.lblSpeciesDes.TabIndex = 191;
            this.lblSpeciesDes.Text = "Notes:";
            // 
            // Form_Species
            // 
            this.AcceptButton = this.btnSpeciesSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(685, 285);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Species";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Species";
            this.panel1.ResumeLayout(false);
            this.grpSpecies.ResumeLayout(false);
            this.grpSpecies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpSpecies;
        private System.Windows.Forms.Button btnSpeciesClose;
        private System.Windows.Forms.TextBox txtSpeciesDes;
        private System.Windows.Forms.Label lblSpeciesDes;
        private System.Windows.Forms.TextBox txtSpeciesName;
        private System.Windows.Forms.Label lblSpeciesName;
        private System.Windows.Forms.TextBox txtSpeciesId;
        private System.Windows.Forms.Label lblSpeciesId;
        private System.Windows.Forms.Button btnSpeciesSave;
    }
}