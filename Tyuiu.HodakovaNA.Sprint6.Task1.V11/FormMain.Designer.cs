
namespace Tyuiu.HodakovaNA.Sprint6.Task1.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_HNA));
            this.GBox1_HNA = new System.Windows.Forms.GroupBox();
            this.ImgBox_HNA = new System.Windows.Forms.PictureBox();
            this.Lab1_HNA = new System.Windows.Forms.Label();
            this.GBox2_HNA = new System.Windows.Forms.GroupBox();
            this.TBoxFinish_HNA = new System.Windows.Forms.TextBox();
            this.TBoxStart_HNA = new System.Windows.Forms.TextBox();
            this.Lab3_HNA = new System.Windows.Forms.Label();
            this.Lab2_HNA = new System.Windows.Forms.Label();
            this.GBox3_HNA = new System.Windows.Forms.GroupBox();
            this.TBoxRes_HNA = new System.Windows.Forms.TextBox();
            this.Lab4_HNA = new System.Windows.Forms.Label();
            this.But1Spravka_HNA = new System.Windows.Forms.Button();
            this.But2Vipolnit_HNA = new System.Windows.Forms.Button();
            this.GBox1_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox_HNA)).BeginInit();
            this.GBox2_HNA.SuspendLayout();
            this.GBox3_HNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox1_HNA
            // 
            this.GBox1_HNA.Controls.Add(this.ImgBox_HNA);
            this.GBox1_HNA.Controls.Add(this.Lab1_HNA);
            this.GBox1_HNA.Location = new System.Drawing.Point(12, 12);
            this.GBox1_HNA.Name = "GBox1_HNA";
            this.GBox1_HNA.Size = new System.Drawing.Size(385, 235);
            this.GBox1_HNA.TabIndex = 0;
            this.GBox1_HNA.TabStop = false;
            this.GBox1_HNA.Text = "Условие";
            // 
            // ImgBox_HNA
            // 
            this.ImgBox_HNA.Image = ((System.Drawing.Image)(resources.GetObject("ImgBox_HNA.Image")));
            this.ImgBox_HNA.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgBox_HNA.InitialImage")));
            this.ImgBox_HNA.Location = new System.Drawing.Point(86, 62);
            this.ImgBox_HNA.Name = "ImgBox_HNA";
            this.ImgBox_HNA.Size = new System.Drawing.Size(293, 45);
            this.ImgBox_HNA.TabIndex = 1;
            this.ImgBox_HNA.TabStop = false;
            this.ImgBox_HNA.Click += new System.EventHandler(this.ImgBox_HNA_Click);
            // 
            // Lab1_HNA
            // 
            this.Lab1_HNA.AutoSize = true;
            this.Lab1_HNA.Location = new System.Drawing.Point(7, 20);
            this.Lab1_HNA.Name = "Lab1_HNA";
            this.Lab1_HNA.Size = new System.Drawing.Size(272, 52);
            this.Lab1_HNA.TabIndex = 0;
            this.Lab1_HNA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "\r\n\r\nФункция:";
            // 
            // GBox2_HNA
            // 
            this.GBox2_HNA.Controls.Add(this.TBoxFinish_HNA);
            this.GBox2_HNA.Controls.Add(this.TBoxStart_HNA);
            this.GBox2_HNA.Controls.Add(this.Lab3_HNA);
            this.GBox2_HNA.Controls.Add(this.Lab2_HNA);
            this.GBox2_HNA.Location = new System.Drawing.Point(12, 253);
            this.GBox2_HNA.Name = "GBox2_HNA";
            this.GBox2_HNA.Size = new System.Drawing.Size(197, 66);
            this.GBox2_HNA.TabIndex = 1;
            this.GBox2_HNA.TabStop = false;
            this.GBox2_HNA.Text = "Ввод данных";
            // 
            // TBoxFinish_HNA
            // 
            this.TBoxFinish_HNA.Location = new System.Drawing.Point(102, 33);
            this.TBoxFinish_HNA.Name = "TBoxFinish_HNA";
            this.TBoxFinish_HNA.Size = new System.Drawing.Size(87, 20);
            this.TBoxFinish_HNA.TabIndex = 3;
            this.TBoxFinish_HNA.TextChanged += new System.EventHandler(this.TBoxFinish_HNA_TextChanged);
            // 
            // TBoxStart_HNA
            // 
            this.TBoxStart_HNA.Location = new System.Drawing.Point(6, 33);
            this.TBoxStart_HNA.Name = "TBoxStart_HNA";
            this.TBoxStart_HNA.Size = new System.Drawing.Size(87, 20);
            this.TBoxStart_HNA.TabIndex = 2;
            this.TBoxStart_HNA.TextChanged += new System.EventHandler(this.TBoxStart_HNA_TextChanged);
            // 
            // Lab3_HNA
            // 
            this.Lab3_HNA.AutoSize = true;
            this.Lab3_HNA.Location = new System.Drawing.Point(99, 16);
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
            // GBox3_HNA
            // 
            this.GBox3_HNA.Controls.Add(this.TBoxRes_HNA);
            this.GBox3_HNA.Controls.Add(this.Lab4_HNA);
            this.GBox3_HNA.Location = new System.Drawing.Point(403, 12);
            this.GBox3_HNA.Name = "GBox3_HNA";
            this.GBox3_HNA.Size = new System.Drawing.Size(255, 307);
            this.GBox3_HNA.TabIndex = 2;
            this.GBox3_HNA.TabStop = false;
            this.GBox3_HNA.Text = "Вывод данных";
            this.GBox3_HNA.Enter += new System.EventHandler(this.GBox3_HNA_Enter);
            // 
            // TBoxRes_HNA
            // 
            this.TBoxRes_HNA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TBoxRes_HNA.Font = new System.Drawing.Font("Consolas", 10F);
            this.TBoxRes_HNA.Location = new System.Drawing.Point(9, 37);
            this.TBoxRes_HNA.Multiline = true;
            this.TBoxRes_HNA.Name = "TBoxRes_HNA";
            this.TBoxRes_HNA.ReadOnly = true;
            this.TBoxRes_HNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBoxRes_HNA.Size = new System.Drawing.Size(240, 240);
            this.TBoxRes_HNA.TabIndex = 1;
            this.TBoxRes_HNA.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.TBoxRes_HNA.TextChanged += new System.EventHandler(this.TBoxRes_HNA_TextChanged);
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
            // But1Spravka_HNA
            // 
            this.But1Spravka_HNA.BackColor = System.Drawing.Color.DodgerBlue;
            this.But1Spravka_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.But1Spravka_HNA.Location = new System.Drawing.Point(216, 258);
            this.But1Spravka_HNA.Name = "But1Spravka_HNA";
            this.But1Spravka_HNA.Size = new System.Drawing.Size(75, 61);
            this.But1Spravka_HNA.TabIndex = 3;
            this.But1Spravka_HNA.Text = "Справка";
            this.But1Spravka_HNA.UseVisualStyleBackColor = false;
            this.But1Spravka_HNA.Click += new System.EventHandler(this.But1Spravka_HNA_Click);
            // 
            // But2Vipolnit_HNA
            // 
            this.But2Vipolnit_HNA.BackColor = System.Drawing.Color.SeaGreen;
            this.But2Vipolnit_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.But2Vipolnit_HNA.Location = new System.Drawing.Point(295, 258);
            this.But2Vipolnit_HNA.Name = "But2Vipolnit_HNA";
            this.But2Vipolnit_HNA.Size = new System.Drawing.Size(102, 61);
            this.But2Vipolnit_HNA.TabIndex = 4;
            this.But2Vipolnit_HNA.Text = "Выполнить";
            this.But2Vipolnit_HNA.UseVisualStyleBackColor = false;
            this.But2Vipolnit_HNA.Click += new System.EventHandler(this.But2Vipolnit_HNA_Click);
            // 
            // FormMain_HNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.But2Vipolnit_HNA);
            this.Controls.Add(this.But1Spravka_HNA);
            this.Controls.Add(this.GBox3_HNA);
            this.Controls.Add(this.GBox2_HNA);
            this.Controls.Add(this.GBox1_HNA);
            this.Name = "FormMain_HNA";
            this.Text = "Спринт 6 | Таск 1 | Вариант 11 | Ходакова Н.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GBox1_HNA.ResumeLayout(false);
            this.GBox1_HNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox_HNA)).EndInit();
            this.GBox2_HNA.ResumeLayout(false);
            this.GBox2_HNA.PerformLayout();
            this.GBox3_HNA.ResumeLayout(false);
            this.GBox3_HNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox1_HNA;
        private System.Windows.Forms.Label Lab1_HNA;
        private System.Windows.Forms.GroupBox GBox2_HNA;
        private System.Windows.Forms.GroupBox GBox3_HNA;
        private System.Windows.Forms.PictureBox ImgBox_HNA;
        private System.Windows.Forms.Label Lab3_HNA;
        private System.Windows.Forms.Label Lab2_HNA;
        private System.Windows.Forms.TextBox TBoxFinish_HNA;
        private System.Windows.Forms.TextBox TBoxStart_HNA;
        private System.Windows.Forms.TextBox TBoxRes_HNA;
        private System.Windows.Forms.Label Lab4_HNA;
        private System.Windows.Forms.Button But1Spravka_HNA;
        private System.Windows.Forms.Button But2Vipolnit_HNA;
    }
}

