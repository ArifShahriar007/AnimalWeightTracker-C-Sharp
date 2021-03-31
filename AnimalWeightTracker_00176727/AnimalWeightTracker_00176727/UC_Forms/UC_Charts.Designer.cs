namespace AnimalWeightTracker_00176727.UC_Forms
{
    partial class UC_Charts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.mTabControlChart = new MetroFramework.Controls.MetroTabControl();
            this.mTabPageCharts = new MetroFramework.Controls.MetroTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblLossGain = new System.Windows.Forms.Label();
            this.lblAVG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnChartPrintR = new System.Windows.Forms.Button();
            this.pnlMiddle.SuspendLayout();
            this.mTabControlChart.SuspendLayout();
            this.mTabPageCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.mTabControlChart);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(25, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1075, 485);
            this.pnlMiddle.TabIndex = 28;
            // 
            // mTabControlChart
            // 
            this.mTabControlChart.Controls.Add(this.mTabPageCharts);
            this.mTabControlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabControlChart.Location = new System.Drawing.Point(0, 0);
            this.mTabControlChart.Name = "mTabControlChart";
            this.mTabControlChart.SelectedIndex = 0;
            this.mTabControlChart.Size = new System.Drawing.Size(1075, 485);
            this.mTabControlChart.TabIndex = 0;
            this.mTabControlChart.UseSelectable = true;
            // 
            // mTabPageCharts
            // 
            this.mTabPageCharts.Controls.Add(this.btnChartPrintR);
            this.mTabPageCharts.Controls.Add(this.label3);
            this.mTabPageCharts.Controls.Add(this.chart1);
            this.mTabPageCharts.Controls.Add(this.comboBox1);
            this.mTabPageCharts.Controls.Add(this.lblLossGain);
            this.mTabPageCharts.Controls.Add(this.lblAVG);
            this.mTabPageCharts.Controls.Add(this.label2);
            this.mTabPageCharts.Controls.Add(this.label1);
            this.mTabPageCharts.HorizontalScrollbarBarColor = true;
            this.mTabPageCharts.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabPageCharts.HorizontalScrollbarSize = 10;
            this.mTabPageCharts.Location = new System.Drawing.Point(4, 38);
            this.mTabPageCharts.Name = "mTabPageCharts";
            this.mTabPageCharts.Size = new System.Drawing.Size(1067, 443);
            this.mTabPageCharts.TabIndex = 0;
            this.mTabPageCharts.Text = "Daily Measurement Charts";
            this.mTabPageCharts.VerticalScrollbarBarColor = true;
            this.mTabPageCharts.VerticalScrollbarHighlightOnWheel = false;
            this.mTabPageCharts.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Animal:";
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(185, 64);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(697, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(317, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(390, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // lblLossGain
            // 
            this.lblLossGain.AutoSize = true;
            this.lblLossGain.Location = new System.Drawing.Point(346, 410);
            this.lblLossGain.Name = "lblLossGain";
            this.lblLossGain.Size = new System.Drawing.Size(25, 20);
            this.lblLossGain.TabIndex = 5;
            this.lblLossGain.Text = "00";
            // 
            // lblAVG
            // 
            this.lblAVG.AutoSize = true;
            this.lblAVG.Location = new System.Drawing.Point(310, 377);
            this.lblAVG.Name = "lblAVG";
            this.lblAVG.Size = new System.Drawing.Size(25, 20);
            this.lblAVG.TabIndex = 6;
            this.lblAVG.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight Loss/Gain:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "AVG Weight:";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblCopyright);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(25, 485);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1075, 30);
            this.pnlBottom.TabIndex = 27;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCopyright.Location = new System.Drawing.Point(7, 7);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(235, 16);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Copyright © 2020-2021. All Rights Reserved.";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(25, 515);
            this.pnlLeft.TabIndex = 25;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1100, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(25, 515);
            this.pnlRight.TabIndex = 26;
            // 
            // btnChartPrintR
            // 
            this.btnChartPrintR.BackColor = System.Drawing.SystemColors.Window;
            this.btnChartPrintR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnChartPrintR.FlatAppearance.BorderSize = 2;
            this.btnChartPrintR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChartPrintR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChartPrintR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChartPrintR.Location = new System.Drawing.Point(632, 400);
            this.btnChartPrintR.Name = "btnChartPrintR";
            this.btnChartPrintR.Size = new System.Drawing.Size(211, 30);
            this.btnChartPrintR.TabIndex = 10;
            this.btnChartPrintR.Text = "Print Report";
            this.btnChartPrintR.UseVisualStyleBackColor = false;
            // 
            // UC_Charts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Charts";
            this.Size = new System.Drawing.Size(1125, 515);
            this.Load += new System.EventHandler(this.UC_Charts_Load);
            this.pnlMiddle.ResumeLayout(false);
            this.mTabControlChart.ResumeLayout(false);
            this.mTabPageCharts.ResumeLayout(false);
            this.mTabPageCharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private MetroFramework.Controls.MetroTabControl mTabControlChart;
        private MetroFramework.Controls.MetroTabPage mTabPageCharts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblLossGain;
        private System.Windows.Forms.Label lblAVG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChartPrintR;
    }
}
