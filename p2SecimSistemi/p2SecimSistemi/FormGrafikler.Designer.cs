namespace p2SecimSistemi
{
    partial class FormGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pBirinci = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pİkinci = new System.Windows.Forms.ProgressBar();
            this.pUcuncu = new System.Windows.Forms.ProgressBar();
            this.pDorduncu = new System.Windows.Forms.ProgressBar();
            this.pBesinci = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBirinci = new System.Windows.Forms.Label();
            this.lblIkinci = new System.Windows.Forms.Label();
            this.lblUcuncu = new System.Windows.Forms.Label();
            this.lblDorduncu = new System.Windows.Forms.Label();
            this.lblBesinci = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 29);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(986, 278);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBesinci);
            this.groupBox2.Controls.Add(this.lblDorduncu);
            this.groupBox2.Controls.Add(this.lblUcuncu);
            this.groupBox2.Controls.Add(this.lblIkinci);
            this.groupBox2.Controls.Add(this.lblBirinci);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pBesinci);
            this.groupBox2.Controls.Add(this.pDorduncu);
            this.groupBox2.Controls.Add(this.pUcuncu);
            this.groupBox2.Controls.Add(this.pİkinci);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pBirinci);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçiniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pBirinci
            // 
            this.pBirinci.Location = new System.Drawing.Point(171, 108);
            this.pBirinci.Maximum = 200;
            this.pBirinci.Name = "pBirinci";
            this.pBirinci.Size = new System.Drawing.Size(669, 33);
            this.pBirinci.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birinci Parti:";
            // 
            // pİkinci
            // 
            this.pİkinci.Location = new System.Drawing.Point(171, 147);
            this.pİkinci.Maximum = 200;
            this.pİkinci.Name = "pİkinci";
            this.pİkinci.Size = new System.Drawing.Size(669, 33);
            this.pİkinci.TabIndex = 4;
            // 
            // pUcuncu
            // 
            this.pUcuncu.Location = new System.Drawing.Point(171, 186);
            this.pUcuncu.Maximum = 200;
            this.pUcuncu.Name = "pUcuncu";
            this.pUcuncu.Size = new System.Drawing.Size(669, 33);
            this.pUcuncu.TabIndex = 5;
            // 
            // pDorduncu
            // 
            this.pDorduncu.Location = new System.Drawing.Point(171, 225);
            this.pDorduncu.Maximum = 200;
            this.pDorduncu.Name = "pDorduncu";
            this.pDorduncu.Size = new System.Drawing.Size(669, 33);
            this.pDorduncu.TabIndex = 6;
            // 
            // pBesinci
            // 
            this.pBesinci.Location = new System.Drawing.Point(171, 264);
            this.pBesinci.Maximum = 200;
            this.pBesinci.Name = "pBesinci";
            this.pBesinci.Size = new System.Drawing.Size(669, 33);
            this.pBesinci.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "İkinci Parti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Üçüncü Parti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dördüncü Parti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Beşinci Parti:";
            // 
            // lblBirinci
            // 
            this.lblBirinci.AutoSize = true;
            this.lblBirinci.Location = new System.Drawing.Point(865, 116);
            this.lblBirinci.Name = "lblBirinci";
            this.lblBirinci.Size = new System.Drawing.Size(22, 25);
            this.lblBirinci.TabIndex = 12;
            this.lblBirinci.Text = "0";
            // 
            // lblIkinci
            // 
            this.lblIkinci.AutoSize = true;
            this.lblIkinci.Location = new System.Drawing.Point(865, 155);
            this.lblIkinci.Name = "lblIkinci";
            this.lblIkinci.Size = new System.Drawing.Size(22, 25);
            this.lblIkinci.TabIndex = 13;
            this.lblIkinci.Text = "0";
            // 
            // lblUcuncu
            // 
            this.lblUcuncu.AutoSize = true;
            this.lblUcuncu.Location = new System.Drawing.Point(865, 194);
            this.lblUcuncu.Name = "lblUcuncu";
            this.lblUcuncu.Size = new System.Drawing.Size(22, 25);
            this.lblUcuncu.TabIndex = 14;
            this.lblUcuncu.Text = "0";
            // 
            // lblDorduncu
            // 
            this.lblDorduncu.AutoSize = true;
            this.lblDorduncu.Location = new System.Drawing.Point(865, 233);
            this.lblDorduncu.Name = "lblDorduncu";
            this.lblDorduncu.Size = new System.Drawing.Size(22, 25);
            this.lblDorduncu.TabIndex = 15;
            this.lblDorduncu.Text = "0";
            // 
            // lblBesinci
            // 
            this.lblBesinci.AutoSize = true;
            this.lblBesinci.Location = new System.Drawing.Point(865, 272);
            this.lblBesinci.Name = "lblBesinci";
            this.lblBesinci.Size = new System.Drawing.Size(22, 25);
            this.lblBesinci.TabIndex = 16;
            this.lblBesinci.Text = "0";
            // 
            // FormGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1016, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Tabanlı Seçim Sistemi";
            this.Load += new System.EventHandler(this.FormGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBesinci;
        private System.Windows.Forms.Label lblDorduncu;
        private System.Windows.Forms.Label lblUcuncu;
        private System.Windows.Forms.Label lblIkinci;
        private System.Windows.Forms.Label lblBirinci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pBesinci;
        private System.Windows.Forms.ProgressBar pDorduncu;
        private System.Windows.Forms.ProgressBar pUcuncu;
        private System.Windows.Forms.ProgressBar pİkinci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pBirinci;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}