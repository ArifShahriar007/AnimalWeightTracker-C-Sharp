namespace AnimalWeightTracker_00176727.Forms
{
    partial class Form_OrgType
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
            this.grpOrgType = new System.Windows.Forms.GroupBox();
            this.btnOrgTypeClose = new System.Windows.Forms.Button();
            this.btnOrgTypeSave = new System.Windows.Forms.Button();
            this.lblOrgType = new System.Windows.Forms.Label();
            this.txtOrgType = new System.Windows.Forms.TextBox();
            this.txtOrgTypeId = new System.Windows.Forms.TextBox();
            this.lblOrgTypeId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpOrgType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.grpOrgType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 209);
            this.panel1.TabIndex = 0;
            // 
            // grpOrgType
            // 
            this.grpOrgType.Controls.Add(this.btnOrgTypeClose);
            this.grpOrgType.Controls.Add(this.btnOrgTypeSave);
            this.grpOrgType.Controls.Add(this.lblOrgType);
            this.grpOrgType.Controls.Add(this.txtOrgType);
            this.grpOrgType.Controls.Add(this.txtOrgTypeId);
            this.grpOrgType.Controls.Add(this.lblOrgTypeId);
            this.grpOrgType.Location = new System.Drawing.Point(16, 22);
            this.grpOrgType.Name = "grpOrgType";
            this.grpOrgType.Size = new System.Drawing.Size(537, 171);
            this.grpOrgType.TabIndex = 0;
            this.grpOrgType.TabStop = false;
            this.grpOrgType.Text = "Organization Type";
            // 
            // btnOrgTypeClose
            // 
            this.btnOrgTypeClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrgTypeClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrgTypeClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOrgTypeClose.FlatAppearance.BorderSize = 2;
            this.btnOrgTypeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrgTypeClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrgTypeClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrgTypeClose.Location = new System.Drawing.Point(273, 122);
            this.btnOrgTypeClose.Name = "btnOrgTypeClose";
            this.btnOrgTypeClose.Size = new System.Drawing.Size(100, 30);
            this.btnOrgTypeClose.TabIndex = 2;
            this.btnOrgTypeClose.Text = "CLOSE";
            this.btnOrgTypeClose.UseVisualStyleBackColor = false;
            this.btnOrgTypeClose.Click += new System.EventHandler(this.btnOrgClose_Click);
            // 
            // btnOrgTypeSave
            // 
            this.btnOrgTypeSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrgTypeSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrgTypeSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOrgTypeSave.FlatAppearance.BorderSize = 2;
            this.btnOrgTypeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrgTypeSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrgTypeSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrgTypeSave.Location = new System.Drawing.Point(388, 122);
            this.btnOrgTypeSave.Name = "btnOrgTypeSave";
            this.btnOrgTypeSave.Size = new System.Drawing.Size(100, 30);
            this.btnOrgTypeSave.TabIndex = 1;
            this.btnOrgTypeSave.Text = "SAVE";
            this.btnOrgTypeSave.UseVisualStyleBackColor = false;
            this.btnOrgTypeSave.Click += new System.EventHandler(this.btnOrgTypeSave_Click);
            // 
            // lblOrgType
            // 
            this.lblOrgType.AutoSize = true;
            this.lblOrgType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgType.Location = new System.Drawing.Point(45, 82);
            this.lblOrgType.Name = "lblOrgType";
            this.lblOrgType.Size = new System.Drawing.Size(128, 17);
            this.lblOrgType.TabIndex = 163;
            this.lblOrgType.Text = "Organization Type:";
            // 
            // txtOrgType
            // 
            this.txtOrgType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgType.Location = new System.Drawing.Point(179, 79);
            this.txtOrgType.Name = "txtOrgType";
            this.txtOrgType.Size = new System.Drawing.Size(309, 23);
            this.txtOrgType.TabIndex = 0;
            // 
            // txtOrgTypeId
            // 
            this.txtOrgTypeId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgTypeId.Location = new System.Drawing.Point(179, 40);
            this.txtOrgTypeId.Name = "txtOrgTypeId";
            this.txtOrgTypeId.ReadOnly = true;
            this.txtOrgTypeId.Size = new System.Drawing.Size(309, 23);
            this.txtOrgTypeId.TabIndex = 3;
            // 
            // lblOrgTypeId
            // 
            this.lblOrgTypeId.AutoSize = true;
            this.lblOrgTypeId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgTypeId.Location = new System.Drawing.Point(28, 43);
            this.lblOrgTypeId.Name = "lblOrgTypeId";
            this.lblOrgTypeId.Size = new System.Drawing.Size(144, 17);
            this.lblOrgTypeId.TabIndex = 164;
            this.lblOrgTypeId.Text = "Organization Type Id:";
            // 
            // Form_OrgType
            // 
            this.AcceptButton = this.btnOrgTypeSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(585, 225);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_OrgType";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_OrgType";
            this.panel1.ResumeLayout(false);
            this.grpOrgType.ResumeLayout(false);
            this.grpOrgType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpOrgType;
        private System.Windows.Forms.Label lblOrgType;
        private System.Windows.Forms.TextBox txtOrgType;
        private System.Windows.Forms.TextBox txtOrgTypeId;
        private System.Windows.Forms.Label lblOrgTypeId;
        private System.Windows.Forms.Button btnOrgTypeClose;
        private System.Windows.Forms.Button btnOrgTypeSave;
    }
}