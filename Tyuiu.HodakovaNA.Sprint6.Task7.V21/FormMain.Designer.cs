
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GBox1Top_HNA = new System.Windows.Forms.GroupBox();
            this.But4Info_HNA = new System.Windows.Forms.Button();
            this.But3Sohr_HNA = new System.Windows.Forms.Button();
            this.But2Dok_HNA = new System.Windows.Forms.Button();
            this.But1File_HNA = new System.Windows.Forms.Button();
            this.GBox3Left_HNA = new System.Windows.Forms.GroupBox();
            this.DGridV1Vvod_HNA = new System.Windows.Forms.DataGridView();
            this.GBox4Right_HNA = new System.Windows.Forms.GroupBox();
            this.DGridV2Vivod_HNA = new System.Windows.Forms.DataGridView();
            this.GBox2Top_HNA = new System.Windows.Forms.GroupBox();
            this.Lib1Uslovie_HNA = new System.Windows.Forms.Label();
            this.OpenFileDialogTask_HNA = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip_HNA = new System.Windows.Forms.ToolTip(this.components);
            this.SaveFileDialogTask_HNA = new System.Windows.Forms.SaveFileDialog();
            this.GBox1Top_HNA.SuspendLayout();
            this.GBox3Left_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridV1Vvod_HNA)).BeginInit();
            this.GBox4Right_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridV2Vivod_HNA)).BeginInit();
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
            // But4Info_HNA
            // 
            this.But4Info_HNA.Dock = System.Windows.Forms.DockStyle.Right;
            this.But4Info_HNA.Image = ((System.Drawing.Image)(resources.GetObject("But4Info_HNA.Image")));
            this.But4Info_HNA.Location = new System.Drawing.Point(623, 16);
            this.But4Info_HNA.Name = "But4Info_HNA";
            this.But4Info_HNA.Size = new System.Drawing.Size(75, 81);
            this.But4Info_HNA.TabIndex = 3;
            this.ToolTip_HNA.SetToolTip(this.But4Info_HNA, "Сведения о программе.");
            this.But4Info_HNA.UseVisualStyleBackColor = true;
            this.But4Info_HNA.Click += new System.EventHandler(this.But4Info_HNA_Click);
            // 
            // But3Sohr_HNA
            // 
            this.But3Sohr_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.But3Sohr_HNA.Image = ((System.Drawing.Image)(resources.GetObject("But3Sohr_HNA.Image")));
            this.But3Sohr_HNA.Location = new System.Drawing.Point(167, 16);
            this.But3Sohr_HNA.Name = "But3Sohr_HNA";
            this.But3Sohr_HNA.Size = new System.Drawing.Size(84, 81);
            this.But3Sohr_HNA.TabIndex = 2;
            this.ToolTip_HNA.SetToolTip(this.But3Sohr_HNA, "Созранить новый объект.");
            this.But3Sohr_HNA.UseVisualStyleBackColor = true;
            this.But3Sohr_HNA.Click += new System.EventHandler(this.But3Sohr_HNA_Click);
            // 
            // But2Dok_HNA
            // 
            this.But2Dok_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.But2Dok_HNA.Image = ((System.Drawing.Image)(resources.GetObject("But2Dok_HNA.Image")));
            this.But2Dok_HNA.Location = new System.Drawing.Point(84, 16);
            this.But2Dok_HNA.Name = "But2Dok_HNA";
            this.But2Dok_HNA.Size = new System.Drawing.Size(83, 81);
            this.But2Dok_HNA.TabIndex = 1;
            this.ToolTip_HNA.SetToolTip(this.But2Dok_HNA, "Произвести выполнение условия.");
            this.But2Dok_HNA.UseVisualStyleBackColor = true;
            this.But2Dok_HNA.Click += new System.EventHandler(this.But2Dok_HNA_Click);
            // 
            // But1File_HNA
            // 
            this.But1File_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.But1File_HNA.Image = ((System.Drawing.Image)(resources.GetObject("But1File_HNA.Image")));
            this.But1File_HNA.Location = new System.Drawing.Point(3, 16);
            this.But1File_HNA.Name = "But1File_HNA";
            this.But1File_HNA.Size = new System.Drawing.Size(81, 81);
            this.But1File_HNA.TabIndex = 0;
            this.ToolTip_HNA.SetToolTip(this.But1File_HNA, "Выберете файл.");
            this.But1File_HNA.UseVisualStyleBackColor = true;
            this.But1File_HNA.Click += new System.EventHandler(this.But1File_HNA_Click);
            // 
            // GBox3Left_HNA
            // 
            this.GBox3Left_HNA.Controls.Add(this.DGridV1Vvod_HNA);
            this.GBox3Left_HNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.GBox3Left_HNA.Location = new System.Drawing.Point(0, 200);
            this.GBox3Left_HNA.Name = "GBox3Left_HNA";
            this.GBox3Left_HNA.Size = new System.Drawing.Size(353, 347);
            this.GBox3Left_HNA.TabIndex = 2;
            this.GBox3Left_HNA.TabStop = false;
            this.GBox3Left_HNA.Text = "Ввод данных:";
            this.GBox3Left_HNA.Enter += new System.EventHandler(this.GBox3Left_HNA_Enter);
            // 
            // DGridV1Vvod_HNA
            // 
            this.DGridV1Vvod_HNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridV1Vvod_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGridV1Vvod_HNA.Location = new System.Drawing.Point(3, 16);
            this.DGridV1Vvod_HNA.Name = "DGridV1Vvod_HNA";
            this.DGridV1Vvod_HNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGridV1Vvod_HNA.Size = new System.Drawing.Size(347, 328);
            this.DGridV1Vvod_HNA.TabIndex = 0;
            this.DGridV1Vvod_HNA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridV1Vvod_HNA_CellContentClick);
            // 
            // GBox4Right_HNA
            // 
            this.GBox4Right_HNA.Controls.Add(this.DGridV2Vivod_HNA);
            this.GBox4Right_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBox4Right_HNA.Location = new System.Drawing.Point(353, 200);
            this.GBox4Right_HNA.Name = "GBox4Right_HNA";
            this.GBox4Right_HNA.Size = new System.Drawing.Size(348, 347);
            this.GBox4Right_HNA.TabIndex = 3;
            this.GBox4Right_HNA.TabStop = false;
            this.GBox4Right_HNA.Text = "Вывод данных:";
            this.GBox4Right_HNA.Enter += new System.EventHandler(this.GBox4Right_HNA_Enter);
            // 
            // DGridV2Vivod_HNA
            // 
            this.DGridV2Vivod_HNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridV2Vivod_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGridV2Vivod_HNA.Location = new System.Drawing.Point(3, 16);
            this.DGridV2Vivod_HNA.Name = "DGridV2Vivod_HNA";
            this.DGridV2Vivod_HNA.ReadOnly = true;
            this.DGridV2Vivod_HNA.Size = new System.Drawing.Size(342, 328);
            this.DGridV2Vivod_HNA.TabIndex = 0;
            this.DGridV2Vivod_HNA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridV2Vivod_HNA_CellContentClick);
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
            // OpenFileDialogTask_HNA
            // 
            this.OpenFileDialogTask_HNA.FileName = "openFileDialog1";
            // 
            // ToolTip_HNA
            // 
            this.ToolTip_HNA.IsBalloon = true;
            this.ToolTip_HNA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_HNA.ToolTipTitle = "Подсказка";
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
            this.Text = "Спринт 6 | Таск 7 | Вариант 21 | Ходакова Н.А.";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.GBox1Top_HNA.ResumeLayout(false);
            this.GBox3Left_HNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridV1Vvod_HNA)).EndInit();
            this.GBox4Right_HNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridV2Vivod_HNA)).EndInit();
            this.GBox2Top_HNA.ResumeLayout(false);
            this.GBox2Top_HNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox1Top_HNA;
        private System.Windows.Forms.GroupBox GBox3Left_HNA;
        private System.Windows.Forms.GroupBox GBox4Right_HNA;
        private System.Windows.Forms.GroupBox GBox2Top_HNA;
        private System.Windows.Forms.Label Lib1Uslovie_HNA;
        private System.Windows.Forms.Button But4Info_HNA;
        private System.Windows.Forms.Button But3Sohr_HNA;
        private System.Windows.Forms.Button But2Dok_HNA;
        private System.Windows.Forms.Button But1File_HNA;
        private System.Windows.Forms.DataGridView DGridV1Vvod_HNA;
        private System.Windows.Forms.DataGridView DGridV2Vivod_HNA;
        private System.Windows.Forms.ToolTip ToolTip_HNA;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogTask_HNA;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogTask_HNA;
    }
}

