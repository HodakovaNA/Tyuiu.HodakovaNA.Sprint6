
namespace Tyuiu.HodakovaNA.Sprint6.Task7.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GBox1Top_HNA = new System.Windows.Forms.GroupBox();
            this.GBox3Left_HNA = new System.Windows.Forms.GroupBox();
            this.GBox4Right_HNA = new System.Windows.Forms.GroupBox();
            this.TBox1Vvod_HNA = new System.Windows.Forms.TextBox();
            this.TBox2Vivod_HNA = new System.Windows.Forms.TextBox();
            this.GBox2Top_HNA = new System.Windows.Forms.GroupBox();
            this.Lib1Uslovie_HNA = new System.Windows.Forms.Label();
            this.But1File_HNA = new System.Windows.Forms.Button();
            this.But2Dok_HNA = new System.Windows.Forms.Button();
            this.But3Sohr_HNA = new System.Windows.Forms.Button();
            this.But4Info_HNA = new System.Windows.Forms.Button();
            this.GBox1Top_HNA.SuspendLayout();
            this.GBox3Left_HNA.SuspendLayout();
            this.GBox4Right_HNA.SuspendLayout();
            this.GBox2Top_HNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox1Top_HNA
            // 
            this.GBox1Top_HNA.Controls.Add(this.But4Info_HNA);
            this.GBox1Top_HNA.Controls.Add(this.But3Sohr_HNA);
            this.GBox1Top_HNA.Controls.Add(this.But2Dok_HNA);
            this.GBox1Top_HNA.Controls.Add(this.But1File_HNA);
            this.GBox1Top_HNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBox1Top_HNA.Location = new System.Drawing.Point(0, 0);
            this.GBox1Top_HNA.Name = "GBox1Top_HNA";
            this.GBox1Top_HNA.Size = new System.Drawing.Size(701, 100);
            this.GBox1Top_HNA.TabIndex = 0;
            this.GBox1Top_HNA.TabStop = false;
            this.GBox1Top_HNA.Enter += new System.EventHandler(this.GBox1Top_HNA_Enter);
            // 
            // GBox3Left_HNA
            // 
            this.GBox3Left_HNA.Controls.Add(this.TBox1Vvod_HNA);
            this.GBox3Left_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.GBox3Left_HNA.Location = new System.Drawing.Point(0, 200);
            this.GBox3Left_HNA.Name = "GBox3Left_HNA";
            this.GBox3Left_HNA.Size = new System.Drawing.Size(356, 347);
            this.GBox3Left_HNA.TabIndex = 2;
            this.GBox3Left_HNA.TabStop = false;
            this.GBox3Left_HNA.Text = "Ввод данных:";
            this.GBox3Left_HNA.Enter += new System.EventHandler(this.GBox3Left_HNA_Enter);
            // 
            // GBox4Right_HNA
            // 
            this.GBox4Right_HNA.Controls.Add(this.TBox2Vivod_HNA);
            this.GBox4Right_HNA.Dock = System.Windows.Forms.DockStyle.Right;
            this.GBox4Right_HNA.Location = new System.Drawing.Point(359, 200);
            this.GBox4Right_HNA.Name = "GBox4Right_HNA";
            this.GBox4Right_HNA.Size = new System.Drawing.Size(342, 347);
            this.GBox4Right_HNA.TabIndex = 3;
            this.GBox4Right_HNA.TabStop = false;
            this.GBox4Right_HNA.Text = "Вывод данных:";
            this.GBox4Right_HNA.Enter += new System.EventHandler(this.GBox4Right_HNA_Enter);
            // 
            // TBox1Vvod_HNA
            // 
            this.TBox1Vvod_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBox1Vvod_HNA.Location = new System.Drawing.Point(3, 16);
            this.TBox1Vvod_HNA.Multiline = true;
            this.TBox1Vvod_HNA.Name = "TBox1Vvod_HNA";
            this.TBox1Vvod_HNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBox1Vvod_HNA.Size = new System.Drawing.Size(350, 328);
            this.TBox1Vvod_HNA.TabIndex = 0;
            this.TBox1Vvod_HNA.TextChanged += new System.EventHandler(this.TBox1Vvod_HNA_TextChanged);
            // 
            // TBox2Vivod_HNA
            // 
            this.TBox2Vivod_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBox2Vivod_HNA.Location = new System.Drawing.Point(3, 16);
            this.TBox2Vivod_HNA.Multiline = true;
            this.TBox2Vivod_HNA.Name = "TBox2Vivod_HNA";
            this.TBox2Vivod_HNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBox2Vivod_HNA.Size = new System.Drawing.Size(336, 328);
            this.TBox2Vivod_HNA.TabIndex = 1;
            this.TBox2Vivod_HNA.TextChanged += new System.EventHandler(this.TBox2Vivod_HNA_TextChanged);
            // 
            // GBox2Top_HNA
            // 
            this.GBox2Top_HNA.Controls.Add(this.Lib1Uslovie_HNA);
            this.GBox2Top_HNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBox2Top_HNA.Location = new System.Drawing.Point(0, 100);
            this.GBox2Top_HNA.Name = "GBox2Top_HNA";
            this.GBox2Top_HNA.Size = new System.Drawing.Size(701, 100);
            this.GBox2Top_HNA.TabIndex = 1;
            this.GBox2Top_HNA.TabStop = false;
            this.GBox2Top_HNA.Text = "Условие";
            this.GBox2Top_HNA.Enter += new System.EventHandler(this.GBox2Top_HNA_Enter);
            // 
            // Lib1Uslovie_HNA
            // 
            this.Lib1Uslovie_HNA.AutoSize = true;
            this.Lib1Uslovie_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lib1Uslovie_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lib1Uslovie_HNA.Location = new System.Drawing.Point(3, 16);
            this.Lib1Uslovie_HNA.Name = "Lib1Uslovie_HNA";
            this.Lib1Uslovie_HNA.Size = new System.Drawing.Size(685, 64);
            this.Lib1Uslovie_HNA.TabIndex = 0;
            this.Lib1Uslovie_HNA.Text = resources.GetString("Lib1Uslovie_HNA.Text");
            this.Lib1Uslovie_HNA.Click += new System.EventHandler(this.Lib1Uslovie_HNA_Click);
            // 
            // But1File_HNA
            // 
            this.But1File_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.But1File_HNA.Location = new System.Drawing.Point(3, 16);
            this.But1File_HNA.Name = "But1File_HNA";
            this.But1File_HNA.Size = new System.Drawing.Size(81, 81);
            this.But1File_HNA.TabIndex = 0;
            this.But1File_HNA.Text = "Папка";
            this.But1File_HNA.UseVisualStyleBackColor = true;
            // 
            // But2Dok_HNA
            // 
            this.But2Dok_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.But2Dok_HNA.Location = new System.Drawing.Point(84, 16);
            this.But2Dok_HNA.Name = "But2Dok_HNA";
            this.But2Dok_HNA.Size = new System.Drawing.Size(83, 81);
            this.But2Dok_HNA.TabIndex = 1;
            this.But2Dok_HNA.Text = "Файл";
            this.But2Dok_HNA.UseVisualStyleBackColor = true;
            // 
            // But3Sohr_HNA
            // 
            this.But3Sohr_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.But3Sohr_HNA.Location = new System.Drawing.Point(167, 16);
            this.But3Sohr_HNA.Name = "But3Sohr_HNA";
            this.But3Sohr_HNA.Size = new System.Drawing.Size(84, 81);
            this.But3Sohr_HNA.TabIndex = 2;
            this.But3Sohr_HNA.Text = "Сохр";
            this.But3Sohr_HNA.UseVisualStyleBackColor = true;
            // 
            // But4Info_HNA
            // 
            this.But4Info_HNA.Dock = System.Windows.Forms.DockStyle.Right;
            this.But4Info_HNA.Location = new System.Drawing.Point(623, 16);
            this.But4Info_HNA.Name = "But4Info_HNA";
            this.But4Info_HNA.Size = new System.Drawing.Size(75, 81);
            this.But4Info_HNA.TabIndex = 3;
            this.But4Info_HNA.Text = "?";
            this.But4Info_HNA.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 547);
            this.Controls.Add(this.GBox4Right_HNA);
            this.Controls.Add(this.GBox3Left_HNA);
            this.Controls.Add(this.GBox2Top_HNA);
            this.Controls.Add(this.GBox1Top_HNA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.GBox1Top_HNA.ResumeLayout(false);
            this.GBox3Left_HNA.ResumeLayout(false);
            this.GBox3Left_HNA.PerformLayout();
            this.GBox4Right_HNA.ResumeLayout(false);
            this.GBox4Right_HNA.PerformLayout();
            this.GBox2Top_HNA.ResumeLayout(false);
            this.GBox2Top_HNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox1Top_HNA;
        private System.Windows.Forms.GroupBox GBox3Left_HNA;
        private System.Windows.Forms.TextBox TBox1Vvod_HNA;
        private System.Windows.Forms.GroupBox GBox4Right_HNA;
        private System.Windows.Forms.TextBox TBox2Vivod_HNA;
        private System.Windows.Forms.GroupBox GBox2Top_HNA;
        private System.Windows.Forms.Label Lib1Uslovie_HNA;
        private System.Windows.Forms.Button But4Info_HNA;
        private System.Windows.Forms.Button But3Sohr_HNA;
        private System.Windows.Forms.Button But2Dok_HNA;
        private System.Windows.Forms.Button But1File_HNA;
    }
}

