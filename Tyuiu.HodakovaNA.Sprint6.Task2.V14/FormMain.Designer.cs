
namespace Tyuiu.HodakovaNA.Sprint6.Task2.V14
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.But2Vipolnit_HNA = new System.Windows.Forms.Button();
            this.But1Spravka_HNA = new System.Windows.Forms.Button();
            this.GBox3_HNA = new System.Windows.Forms.GroupBox();
            this.Grafik_HNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DGridV_HNA = new System.Windows.Forms.DataGridView();
            this.ColumnX_HNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF_HNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab4_HNA = new System.Windows.Forms.Label();
            this.GBox2_HNA = new System.Windows.Forms.GroupBox();
            this.TBoxFinish_HNA = new System.Windows.Forms.TextBox();
            this.TBoxStart_HNA = new System.Windows.Forms.TextBox();
            this.Lab3_HNA = new System.Windows.Forms.Label();
            this.Lab2_HNA = new System.Windows.Forms.Label();
            this.GBox1_HNA = new System.Windows.Forms.GroupBox();
            this.ImgBox_HNA = new System.Windows.Forms.PictureBox();
            this.Lab1_HNA = new System.Windows.Forms.Label();
            this.GBox3_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik_HNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridV_HNA)).BeginInit();
            this.GBox2_HNA.SuspendLayout();
            this.GBox1_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox_HNA)).BeginInit();
            this.SuspendLayout();
            // 
            // But2Vipolnit_HNA
            // 
            this.But2Vipolnit_HNA.BackColor = System.Drawing.Color.SeaGreen;
            this.But2Vipolnit_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.But2Vipolnit_HNA.Location = new System.Drawing.Point(253, 258);
            this.But2Vipolnit_HNA.Name = "But2Vipolnit_HNA";
            this.But2Vipolnit_HNA.Size = new System.Drawing.Size(102, 61);
            this.But2Vipolnit_HNA.TabIndex = 9;
            this.But2Vipolnit_HNA.Text = "Выполнить";
            this.But2Vipolnit_HNA.UseVisualStyleBackColor = false;
            this.But2Vipolnit_HNA.Click += new System.EventHandler(this.But2Vipolnit_HNA_Click);
            this.But2Vipolnit_HNA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.But2Vipolnit_HNA_MauseDown);
            this.But2Vipolnit_HNA.MouseEnter += new System.EventHandler(this.But2Vipolnit_HNA_MauseEntyer);
            this.But2Vipolnit_HNA.MouseLeave += new System.EventHandler(this.But2Vipolnit_HNA_MauseLeave);
            // 
            // But1Spravka_HNA
            // 
            this.But1Spravka_HNA.BackColor = System.Drawing.Color.DodgerBlue;
            this.But1Spravka_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.But1Spravka_HNA.Location = new System.Drawing.Point(172, 258);
            this.But1Spravka_HNA.Name = "But1Spravka_HNA";
            this.But1Spravka_HNA.Size = new System.Drawing.Size(75, 61);
            this.But1Spravka_HNA.TabIndex = 8;
            this.But1Spravka_HNA.Text = "Справка";
            this.But1Spravka_HNA.UseVisualStyleBackColor = false;
            this.But1Spravka_HNA.Click += new System.EventHandler(this.But1Spravka_HNA_Click);
            // 
            // GBox3_HNA
            // 
            this.GBox3_HNA.Controls.Add(this.Grafik_HNA);
            this.GBox3_HNA.Controls.Add(this.DGridV_HNA);
            this.GBox3_HNA.Controls.Add(this.Lab4_HNA);
            this.GBox3_HNA.Location = new System.Drawing.Point(361, 12);
            this.GBox3_HNA.Name = "GBox3_HNA";
            this.GBox3_HNA.Size = new System.Drawing.Size(445, 310);
            this.GBox3_HNA.TabIndex = 7;
            this.GBox3_HNA.TabStop = false;
            this.GBox3_HNA.Text = "Вывод данных";
            // 
            // Grafik_HNA
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafik_HNA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Grafik_HNA.Legends.Add(legend1);
            this.Grafik_HNA.Location = new System.Drawing.Point(126, 20);
            this.Grafik_HNA.Name = "Grafik_HNA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grafik_HNA.Series.Add(series1);
            this.Grafik_HNA.Size = new System.Drawing.Size(310, 280);
            this.Grafik_HNA.TabIndex = 2;
            this.Grafik_HNA.Text = "chart1";
            // 
            // DGridV_HNA
            // 
            this.DGridV_HNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridV_HNA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_HNA,
            this.ColumnF_HNA});
            this.DGridV_HNA.Location = new System.Drawing.Point(10, 40);
            this.DGridV_HNA.Name = "DGridV_HNA";
            this.DGridV_HNA.RowHeadersVisible = false;
            this.DGridV_HNA.Size = new System.Drawing.Size(110, 260);
            this.DGridV_HNA.TabIndex = 1;
            this.DGridV_HNA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnX_HNA
            // 
            this.ColumnX_HNA.HeaderText = "X";
            this.ColumnX_HNA.Name = "ColumnX_HNA";
            this.ColumnX_HNA.ReadOnly = true;
            this.ColumnX_HNA.Width = 50;
            // 
            // ColumnF_HNA
            // 
            this.ColumnF_HNA.HeaderText = "F(X)";
            this.ColumnF_HNA.Name = "ColumnF_HNA";
            this.ColumnF_HNA.ReadOnly = true;
            this.ColumnF_HNA.Width = 50;
            // 
            // Lab4_HNA
            // 
            this.Lab4_HNA.AutoSize = true;
            this.Lab4_HNA.Location = new System.Drawing.Point(6, 20);
            this.Lab4_HNA.Name = "Lab4_HNA";
            this.Lab4_HNA.Size = new System.Drawing.Size(62, 13);
            this.Lab4_HNA.TabIndex = 0;
            this.Lab4_HNA.Text = "Результат:";
            // 
            // GBox2_HNA
            // 
            this.GBox2_HNA.Controls.Add(this.TBoxFinish_HNA);
            this.GBox2_HNA.Controls.Add(this.TBoxStart_HNA);
            this.GBox2_HNA.Controls.Add(this.Lab3_HNA);
            this.GBox2_HNA.Controls.Add(this.Lab2_HNA);
            this.GBox2_HNA.Location = new System.Drawing.Point(12, 253);
            this.GBox2_HNA.Name = "GBox2_HNA";
            this.GBox2_HNA.Size = new System.Drawing.Size(154, 66);
            this.GBox2_HNA.TabIndex = 6;
            this.GBox2_HNA.TabStop = false;
            this.GBox2_HNA.Text = "Ввод данных";
            // 
            // TBoxFinish_HNA
            // 
            this.TBoxFinish_HNA.Location = new System.Drawing.Point(79, 33);
            this.TBoxFinish_HNA.Name = "TBoxFinish_HNA";
            this.TBoxFinish_HNA.Size = new System.Drawing.Size(66, 20);
            this.TBoxFinish_HNA.TabIndex = 3;
            // 
            // TBoxStart_HNA
            // 
            this.TBoxStart_HNA.Location = new System.Drawing.Point(6, 33);
            this.TBoxStart_HNA.Name = "TBoxStart_HNA";
            this.TBoxStart_HNA.Size = new System.Drawing.Size(67, 20);
            this.TBoxStart_HNA.TabIndex = 2;
            this.TBoxStart_HNA.TextChanged += new System.EventHandler(this.TBoxStart_HNA_TextChanged);
            // 
            // Lab3_HNA
            // 
            this.Lab3_HNA.AutoSize = true;
            this.Lab3_HNA.Location = new System.Drawing.Point(76, 16);
            this.Lab3_HNA.Name = "Lab3_HNA";
            this.Lab3_HNA.Size = new System.Drawing.Size(69, 13);
            this.Lab3_HNA.TabIndex = 1;
            this.Lab3_HNA.Text = "Конец шага:";
            // 
            // Lab2_HNA
            // 
            this.Lab2_HNA.AutoSize = true;
            this.Lab2_HNA.Location = new System.Drawing.Point(6, 16);
            this.Lab2_HNA.Name = "Lab2_HNA";
            this.Lab2_HNA.Size = new System.Drawing.Size(67, 13);
            this.Lab2_HNA.TabIndex = 0;
            this.Lab2_HNA.Text = "Старт шага:";
            // 
            // GBox1_HNA
            // 
            this.GBox1_HNA.Controls.Add(this.ImgBox_HNA);
            this.GBox1_HNA.Controls.Add(this.Lab1_HNA);
            this.GBox1_HNA.Location = new System.Drawing.Point(12, 12);
            this.GBox1_HNA.Name = "GBox1_HNA";
            this.GBox1_HNA.Size = new System.Drawing.Size(343, 235);
            this.GBox1_HNA.TabIndex = 5;
            this.GBox1_HNA.TabStop = false;
            this.GBox1_HNA.Text = "Условие";
            // 
            // ImgBox_HNA
            // 
            this.ImgBox_HNA.Image = ((System.Drawing.Image)(resources.GetObject("ImgBox_HNA.Image")));
            this.ImgBox_HNA.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgBox_HNA.InitialImage")));
            this.ImgBox_HNA.Location = new System.Drawing.Point(79, 57);
            this.ImgBox_HNA.Name = "ImgBox_HNA";
            this.ImgBox_HNA.Size = new System.Drawing.Size(248, 42);
            this.ImgBox_HNA.TabIndex = 1;
            this.ImgBox_HNA.TabStop = false;
            this.ImgBox_HNA.Click += new System.EventHandler(this.ImgBox_HNA_Click);
            // 
            // Lab1_HNA
            // 
            this.Lab1_HNA.AutoSize = true;
            this.Lab1_HNA.Location = new System.Drawing.Point(7, 20);
            this.Lab1_HNA.Name = "Lab1_HNA";
            this.Lab1_HNA.Size = new System.Drawing.Size(335, 52);
            this.Lab1_HNA.TabIndex = 0;
            this.Lab1_HNA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.\r\n\r\nФункция:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 326);
            this.Controls.Add(this.But2Vipolnit_HNA);
            this.Controls.Add(this.But1Spravka_HNA);
            this.Controls.Add(this.GBox3_HNA);
            this.Controls.Add(this.GBox2_HNA);
            this.Controls.Add(this.GBox1_HNA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 14 | Ходакова Н.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GBox3_HNA.ResumeLayout(false);
            this.GBox3_HNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik_HNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridV_HNA)).EndInit();
            this.GBox2_HNA.ResumeLayout(false);
            this.GBox2_HNA.PerformLayout();
            this.GBox1_HNA.ResumeLayout(false);
            this.GBox1_HNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox_HNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But2Vipolnit_HNA;
        private System.Windows.Forms.Button But1Spravka_HNA;
        private System.Windows.Forms.GroupBox GBox3_HNA;
        private System.Windows.Forms.Label Lab4_HNA;
        private System.Windows.Forms.GroupBox GBox2_HNA;
        private System.Windows.Forms.TextBox TBoxFinish_HNA;
        private System.Windows.Forms.TextBox TBoxStart_HNA;
        private System.Windows.Forms.Label Lab3_HNA;
        private System.Windows.Forms.Label Lab2_HNA;
        private System.Windows.Forms.GroupBox GBox1_HNA;
        private System.Windows.Forms.PictureBox ImgBox_HNA;
        private System.Windows.Forms.Label Lab1_HNA;
        private System.Windows.Forms.DataGridView DGridV_HNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_HNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF_HNA;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafik_HNA;
    }
}

