
namespace Tyuiu.HodakovaNA.Sprint6.Task3.V16
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
            this.GBoxUslovie_HNA = new System.Windows.Forms.GroupBox();
            this.DGridViewTable_HNA = new System.Windows.Forms.DataGridView();
            this.Column1_HNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_HNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_HNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_HNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_HNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab1Uslovie_HNA = new System.Windows.Forms.Label();
            this.GBoxVihod_HNA = new System.Windows.Forms.GroupBox();
            this.TBoxRes_HNA = new System.Windows.Forms.TextBox();
            this.Lab2Res_HNA = new System.Windows.Forms.Label();
            this.But1Info_HNA = new System.Windows.Forms.Button();
            this.But2Vicheslit_HNA = new System.Windows.Forms.Button();
            this.GBoxUslovie_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridViewTable_HNA)).BeginInit();
            this.GBoxVihod_HNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxUslovie_HNA
            // 
            this.GBoxUslovie_HNA.Controls.Add(this.DGridViewTable_HNA);
            this.GBoxUslovie_HNA.Controls.Add(this.Lab1Uslovie_HNA);
            this.GBoxUslovie_HNA.Location = new System.Drawing.Point(13, 25);
            this.GBoxUslovie_HNA.Name = "GBoxUslovie_HNA";
            this.GBoxUslovie_HNA.Size = new System.Drawing.Size(482, 244);
            this.GBoxUslovie_HNA.TabIndex = 0;
            this.GBoxUslovie_HNA.TabStop = false;
            this.GBoxUslovie_HNA.Text = "Условие";
            // 
            // DGridViewTable_HNA
            // 
            this.DGridViewTable_HNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridViewTable_HNA.ColumnHeadersVisible = false;
            this.DGridViewTable_HNA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_HNA,
            this.Column2_HNA,
            this.Column3_HNA,
            this.Column4_HNA,
            this.Column5_HNA});
            this.DGridViewTable_HNA.Location = new System.Drawing.Point(223, 18);
            this.DGridViewTable_HNA.Name = "DGridViewTable_HNA";
            this.DGridViewTable_HNA.RowHeadersVisible = false;
            this.DGridViewTable_HNA.Size = new System.Drawing.Size(253, 220);
            this.DGridViewTable_HNA.TabIndex = 1;
            this.DGridViewTable_HNA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridViewTable_HNA_CellContentClick);
            // 
            // Column1_HNA
            // 
            this.Column1_HNA.HeaderText = "1";
            this.Column1_HNA.Name = "Column1_HNA";
            this.Column1_HNA.ReadOnly = true;
            this.Column1_HNA.Width = 40;
            // 
            // Column2_HNA
            // 
            this.Column2_HNA.HeaderText = "2";
            this.Column2_HNA.Name = "Column2_HNA";
            this.Column2_HNA.ReadOnly = true;
            this.Column2_HNA.Width = 40;
            // 
            // Column3_HNA
            // 
            this.Column3_HNA.HeaderText = "3";
            this.Column3_HNA.Name = "Column3_HNA";
            this.Column3_HNA.ReadOnly = true;
            this.Column3_HNA.Width = 40;
            // 
            // Column4_HNA
            // 
            this.Column4_HNA.HeaderText = "4";
            this.Column4_HNA.Name = "Column4_HNA";
            this.Column4_HNA.ReadOnly = true;
            this.Column4_HNA.Width = 40;
            // 
            // Column5_HNA
            // 
            this.Column5_HNA.HeaderText = "5";
            this.Column5_HNA.Name = "Column5_HNA";
            this.Column5_HNA.ReadOnly = true;
            this.Column5_HNA.Width = 40;
            // 
            // Lab1Uslovie_HNA
            // 
            this.Lab1Uslovie_HNA.AutoSize = true;
            this.Lab1Uslovie_HNA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lab1Uslovie_HNA.Location = new System.Drawing.Point(7, 20);
            this.Lab1Uslovie_HNA.Name = "Lab1Uslovie_HNA";
            this.Lab1Uslovie_HNA.Size = new System.Drawing.Size(210, 150);
            this.Lab1Uslovie_HNA.TabIndex = 0;
            this.Lab1Uslovie_HNA.Text = resources.GetString("Lab1Uslovie_HNA.Text");
            // 
            // GBoxVihod_HNA
            // 
            this.GBoxVihod_HNA.Controls.Add(this.TBoxRes_HNA);
            this.GBoxVihod_HNA.Controls.Add(this.Lab2Res_HNA);
            this.GBoxVihod_HNA.Location = new System.Drawing.Point(501, 25);
            this.GBoxVihod_HNA.Name = "GBoxVihod_HNA";
            this.GBoxVihod_HNA.Size = new System.Drawing.Size(141, 100);
            this.GBoxVihod_HNA.TabIndex = 1;
            this.GBoxVihod_HNA.TabStop = false;
            this.GBoxVihod_HNA.Text = "Вывод данных";
            // 
            // TBoxRes_HNA
            // 
            this.TBoxRes_HNA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TBoxRes_HNA.Location = new System.Drawing.Point(10, 37);
            this.TBoxRes_HNA.Multiline = true;
            this.TBoxRes_HNA.Name = "TBoxRes_HNA";
            this.TBoxRes_HNA.ReadOnly = true;
            this.TBoxRes_HNA.Size = new System.Drawing.Size(100, 20);
            this.TBoxRes_HNA.TabIndex = 1;
            this.TBoxRes_HNA.TextChanged += new System.EventHandler(this.TBoxRes_HNA_TextChanged);
            // 
            // Lab2Res_HNA
            // 
            this.Lab2Res_HNA.AutoSize = true;
            this.Lab2Res_HNA.Location = new System.Drawing.Point(7, 20);
            this.Lab2Res_HNA.Name = "Lab2Res_HNA";
            this.Lab2Res_HNA.Size = new System.Drawing.Size(62, 13);
            this.Lab2Res_HNA.TabIndex = 0;
            this.Lab2Res_HNA.Text = "Результат:";
            // 
            // But1Info_HNA
            // 
            this.But1Info_HNA.Location = new System.Drawing.Point(501, 234);
            this.But1Info_HNA.Name = "But1Info_HNA";
            this.But1Info_HNA.Size = new System.Drawing.Size(35, 35);
            this.But1Info_HNA.TabIndex = 2;
            this.But1Info_HNA.Text = "?";
            this.But1Info_HNA.UseVisualStyleBackColor = true;
            this.But1Info_HNA.Click += new System.EventHandler(this.But1Info_HNA_Click);
            // 
            // But2Vicheslit_HNA
            // 
            this.But2Vicheslit_HNA.Location = new System.Drawing.Point(542, 234);
            this.But2Vicheslit_HNA.Name = "But2Vicheslit_HNA";
            this.But2Vicheslit_HNA.Size = new System.Drawing.Size(100, 35);
            this.But2Vicheslit_HNA.TabIndex = 3;
            this.But2Vicheslit_HNA.Text = "Вычислить";
            this.But2Vicheslit_HNA.UseVisualStyleBackColor = true;
            this.But2Vicheslit_HNA.Click += new System.EventHandler(this.But2Vicheslit_HNA_Click_1);
            // 
            // FormMain_HNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 281);
            this.Controls.Add(this.But2Vicheslit_HNA);
            this.Controls.Add(this.But1Info_HNA);
            this.Controls.Add(this.GBoxVihod_HNA);
            this.Controls.Add(this.GBoxUslovie_HNA);
            this.Name = "FormMain_HNA";
            this.Text = "Спринт 6 | Таск 3 | Вариант 16 | Ходакова Н.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GBoxUslovie_HNA.ResumeLayout(false);
            this.GBoxUslovie_HNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridViewTable_HNA)).EndInit();
            this.GBoxVihod_HNA.ResumeLayout(false);
            this.GBoxVihod_HNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxUslovie_HNA;
        private System.Windows.Forms.Label Lab1Uslovie_HNA;
        private System.Windows.Forms.GroupBox GBoxVihod_HNA;
        private System.Windows.Forms.Label Lab2Res_HNA;
        private System.Windows.Forms.TextBox TBoxRes_HNA;
        private System.Windows.Forms.DataGridView DGridViewTable_HNA;
        private System.Windows.Forms.Button But1Info_HNA;
        private System.Windows.Forms.Button But2Vicheslit_HNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_HNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_HNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_HNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4_HNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5_HNA;
    }
}

