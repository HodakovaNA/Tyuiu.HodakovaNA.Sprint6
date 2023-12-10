
namespace Tyuiu.HodakovaNA.Sprint6.Task4.V15
{
    partial class FormMain_HNA
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
            this.DBox3Vivod_HNA = new System.Windows.Forms.GroupBox();
            this.Chart1Grafik_HNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBox3Res_HNA = new System.Windows.Forms.TextBox();
            this.GBoxFon_HNA = new System.Windows.Forms.GroupBox();
            this.GBoxUslovie_HNA = new System.Windows.Forms.GroupBox();
            this.Lib1Uslovie_HNA = new System.Windows.Forms.Label();
            this.GBoxVvod_HNA = new System.Windows.Forms.GroupBox();
            this.Lib1Start_HNA = new System.Windows.Forms.Label();
            this.Lib2Stop_HNA = new System.Windows.Forms.Label();
            this.TBox1Start_HNA = new System.Windows.Forms.TextBox();
            this.TBox2Stop_HNA = new System.Windows.Forms.TextBox();
            this.But1Vipolnit_HNA = new System.Windows.Forms.Button();
            this.But2Sohranit_HNA = new System.Windows.Forms.Button();
            this.But3Spavka_HNA = new System.Windows.Forms.Button();
            this.DBox3Vivod_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1Grafik_HNA)).BeginInit();
            this.GBoxFon_HNA.SuspendLayout();
            this.GBoxUslovie_HNA.SuspendLayout();
            this.GBoxVvod_HNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBox3Vivod_HNA
            // 
            this.DBox3Vivod_HNA.Controls.Add(this.TBox3Res_HNA);
            this.DBox3Vivod_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.DBox3Vivod_HNA.Location = new System.Drawing.Point(0, 93);
            this.DBox3Vivod_HNA.Name = "DBox3Vivod_HNA";
            this.DBox3Vivod_HNA.Size = new System.Drawing.Size(200, 368);
            this.DBox3Vivod_HNA.TabIndex = 5;
            this.DBox3Vivod_HNA.TabStop = false;
            this.DBox3Vivod_HNA.Text = "Вывод данных";
            // 
            // Chart1Grafik_HNA
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1Grafik_HNA.ChartAreas.Add(chartArea1);
            this.Chart1Grafik_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Chart1Grafik_HNA.Legends.Add(legend1);
            this.Chart1Grafik_HNA.Location = new System.Drawing.Point(200, 93);
            this.Chart1Grafik_HNA.Name = "Chart1Grafik_HNA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1Grafik_HNA.Series.Add(series1);
            this.Chart1Grafik_HNA.Size = new System.Drawing.Size(584, 368);
            this.Chart1Grafik_HNA.TabIndex = 6;
            this.Chart1Grafik_HNA.Text = "График";
            this.Chart1Grafik_HNA.Click += new System.EventHandler(this.Chart1Grafik_HNA_Click);
            // 
            // TBox3Res_HNA
            // 
            this.TBox3Res_HNA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TBox3Res_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBox3Res_HNA.Location = new System.Drawing.Point(3, 16);
            this.TBox3Res_HNA.Multiline = true;
            this.TBox3Res_HNA.Name = "TBox3Res_HNA";
            this.TBox3Res_HNA.ReadOnly = true;
            this.TBox3Res_HNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBox3Res_HNA.Size = new System.Drawing.Size(194, 349);
            this.TBox3Res_HNA.TabIndex = 0;
            // 
            // GBoxFon_HNA
            // 
            this.GBoxFon_HNA.Controls.Add(this.But3Spavka_HNA);
            this.GBoxFon_HNA.Controls.Add(this.But2Sohranit_HNA);
            this.GBoxFon_HNA.Controls.Add(this.But1Vipolnit_HNA);
            this.GBoxFon_HNA.Controls.Add(this.GBoxVvod_HNA);
            this.GBoxFon_HNA.Controls.Add(this.GBoxUslovie_HNA);
            this.GBoxFon_HNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBoxFon_HNA.Location = new System.Drawing.Point(0, 0);
            this.GBoxFon_HNA.Name = "GBoxFon_HNA";
            this.GBoxFon_HNA.Size = new System.Drawing.Size(784, 93);
            this.GBoxFon_HNA.TabIndex = 0;
            this.GBoxFon_HNA.TabStop = false;
            // 
            // GBoxUslovie_HNA
            // 
            this.GBoxUslovie_HNA.Controls.Add(this.Lib1Uslovie_HNA);
            this.GBoxUslovie_HNA.Location = new System.Drawing.Point(6, 12);
            this.GBoxUslovie_HNA.Name = "GBoxUslovie_HNA";
            this.GBoxUslovie_HNA.Size = new System.Drawing.Size(337, 75);
            this.GBoxUslovie_HNA.TabIndex = 2;
            this.GBoxUslovie_HNA.TabStop = false;
            this.GBoxUslovie_HNA.Text = "Условие";
            // 
            // Lib1Uslovie_HNA
            // 
            this.Lib1Uslovie_HNA.AutoSize = true;
            this.Lib1Uslovie_HNA.Location = new System.Drawing.Point(7, 20);
            this.Lib1Uslovie_HNA.Name = "Lib1Uslovie_HNA";
            this.Lib1Uslovie_HNA.Size = new System.Drawing.Size(322, 39);
            this.Lib1Uslovie_HNA.TabIndex = 0;
            this.Lib1Uslovie_HNA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в Te" +
    "xtBox, построить график функции и \r\nсохранить в файл OutPutFileTask.txt по наати" +
    "ю кнопки.";
            // 
            // GBoxVvod_HNA
            // 
            this.GBoxVvod_HNA.Controls.Add(this.TBox2Stop_HNA);
            this.GBoxVvod_HNA.Controls.Add(this.TBox1Start_HNA);
            this.GBoxVvod_HNA.Controls.Add(this.Lib2Stop_HNA);
            this.GBoxVvod_HNA.Controls.Add(this.Lib1Start_HNA);
            this.GBoxVvod_HNA.Location = new System.Drawing.Point(350, 13);
            this.GBoxVvod_HNA.Name = "GBoxVvod_HNA";
            this.GBoxVvod_HNA.Size = new System.Drawing.Size(157, 74);
            this.GBoxVvod_HNA.TabIndex = 3;
            this.GBoxVvod_HNA.TabStop = false;
            this.GBoxVvod_HNA.Text = "Ввод данных";
            // 
            // Lib1Start_HNA
            // 
            this.Lib1Start_HNA.AutoSize = true;
            this.Lib1Start_HNA.Location = new System.Drawing.Point(6, 19);
            this.Lib1Start_HNA.Name = "Lib1Start_HNA";
            this.Lib1Start_HNA.Size = new System.Drawing.Size(67, 13);
            this.Lib1Start_HNA.TabIndex = 1;
            this.Lib1Start_HNA.Text = "Старт шага:";
            // 
            // Lib2Stop_HNA
            // 
            this.Lib2Stop_HNA.AutoSize = true;
            this.Lib2Stop_HNA.Location = new System.Drawing.Point(79, 19);
            this.Lib2Stop_HNA.Name = "Lib2Stop_HNA";
            this.Lib2Stop_HNA.Size = new System.Drawing.Size(69, 13);
            this.Lib2Stop_HNA.TabIndex = 2;
            this.Lib2Stop_HNA.Text = "Конец шага:";
            // 
            // TBox1Start_HNA
            // 
            this.TBox1Start_HNA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TBox1Start_HNA.Location = new System.Drawing.Point(6, 35);
            this.TBox1Start_HNA.Name = "TBox1Start_HNA";
            this.TBox1Start_HNA.Size = new System.Drawing.Size(67, 20);
            this.TBox1Start_HNA.TabIndex = 3;
            // 
            // TBox2Stop_HNA
            // 
            this.TBox2Stop_HNA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TBox2Stop_HNA.Location = new System.Drawing.Point(82, 35);
            this.TBox2Stop_HNA.Name = "TBox2Stop_HNA";
            this.TBox2Stop_HNA.Size = new System.Drawing.Size(66, 20);
            this.TBox2Stop_HNA.TabIndex = 4;
            // 
            // But1Vipolnit_HNA
            // 
            this.But1Vipolnit_HNA.BackColor = System.Drawing.Color.ForestGreen;
            this.But1Vipolnit_HNA.Location = new System.Drawing.Point(513, 20);
            this.But1Vipolnit_HNA.Name = "But1Vipolnit_HNA";
            this.But1Vipolnit_HNA.Size = new System.Drawing.Size(75, 52);
            this.But1Vipolnit_HNA.TabIndex = 4;
            this.But1Vipolnit_HNA.Text = "Выполнить";
            this.But1Vipolnit_HNA.UseVisualStyleBackColor = false;
            this.But1Vipolnit_HNA.Click += new System.EventHandler(this.But1Vipolnit_HNA_Click);
            // 
            // But2Sohranit_HNA
            // 
            this.But2Sohranit_HNA.BackColor = System.Drawing.Color.RoyalBlue;
            this.But2Sohranit_HNA.Location = new System.Drawing.Point(594, 20);
            this.But2Sohranit_HNA.Name = "But2Sohranit_HNA";
            this.But2Sohranit_HNA.Size = new System.Drawing.Size(75, 52);
            this.But2Sohranit_HNA.TabIndex = 5;
            this.But2Sohranit_HNA.Text = "Сохранить";
            this.But2Sohranit_HNA.UseVisualStyleBackColor = false;
            this.But2Sohranit_HNA.Click += new System.EventHandler(this.But2Sohranit_HNA_Click);
            // 
            // But3Spavka_HNA
            // 
            this.But3Spavka_HNA.BackColor = System.Drawing.Color.DodgerBlue;
            this.But3Spavka_HNA.Location = new System.Drawing.Point(703, 20);
            this.But3Spavka_HNA.Name = "But3Spavka_HNA";
            this.But3Spavka_HNA.Size = new System.Drawing.Size(75, 52);
            this.But3Spavka_HNA.TabIndex = 6;
            this.But3Spavka_HNA.Text = "Справка";
            this.But3Spavka_HNA.UseVisualStyleBackColor = false;
            this.But3Spavka_HNA.Click += new System.EventHandler(this.But3Spavka_HNA_Click);
            // 
            // FormMain_HNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Chart1Grafik_HNA);
            this.Controls.Add(this.DBox3Vivod_HNA);
            this.Controls.Add(this.GBoxFon_HNA);
            this.Name = "FormMain_HNA";
            this.Text = "Спринт 6 | Таск 4 | Вариант 15 | Ходакова Н.А.";
            this.DBox3Vivod_HNA.ResumeLayout(false);
            this.DBox3Vivod_HNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1Grafik_HNA)).EndInit();
            this.GBoxFon_HNA.ResumeLayout(false);
            this.GBoxUslovie_HNA.ResumeLayout(false);
            this.GBoxUslovie_HNA.PerformLayout();
            this.GBoxVvod_HNA.ResumeLayout(false);
            this.GBoxVvod_HNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DBox3Vivod_HNA;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1Grafik_HNA;
        private System.Windows.Forms.TextBox TBox3Res_HNA;
        private System.Windows.Forms.GroupBox GBoxFon_HNA;
        private System.Windows.Forms.GroupBox GBoxVvod_HNA;
        private System.Windows.Forms.TextBox TBox2Stop_HNA;
        private System.Windows.Forms.TextBox TBox1Start_HNA;
        private System.Windows.Forms.Label Lib2Stop_HNA;
        private System.Windows.Forms.Label Lib1Start_HNA;
        private System.Windows.Forms.GroupBox GBoxUslovie_HNA;
        private System.Windows.Forms.Label Lib1Uslovie_HNA;
        private System.Windows.Forms.Button But3Spavka_HNA;
        private System.Windows.Forms.Button But2Sohranit_HNA;
        private System.Windows.Forms.Button But1Vipolnit_HNA;
    }
}

