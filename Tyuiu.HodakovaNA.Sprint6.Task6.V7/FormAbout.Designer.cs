
namespace Tyuiu.HodakovaNA.Sprint6.Task6.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.ButOK_HNA = new System.Windows.Forms.Button();
            this.PictureBox1Img_HNA = new System.Windows.Forms.PictureBox();
            this.LabelFormAbout_HNA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1Img_HNA)).BeginInit();
            this.SuspendLayout();
            // 
            // ButOK_HNA
            // 
            this.ButOK_HNA.Location = new System.Drawing.Point(337, 139);
            this.ButOK_HNA.Name = "ButOK_HNA";
            this.ButOK_HNA.Size = new System.Drawing.Size(75, 23);
            this.ButOK_HNA.TabIndex = 5;
            this.ButOK_HNA.Text = "OK";
            this.ButOK_HNA.UseVisualStyleBackColor = true;
            this.ButOK_HNA.Click += new System.EventHandler(this.ButOK_HNA_Click);
            // 
            // PictureBox1Img_HNA
            // 
            this.PictureBox1Img_HNA.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1Img_HNA.Image")));
            this.PictureBox1Img_HNA.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1Img_HNA.Name = "PictureBox1Img_HNA";
            this.PictureBox1Img_HNA.Size = new System.Drawing.Size(120, 143);
            this.PictureBox1Img_HNA.TabIndex = 4;
            this.PictureBox1Img_HNA.TabStop = false;
            // 
            // LabelFormAbout_HNA
            // 
            this.LabelFormAbout_HNA.AutoSize = true;
            this.LabelFormAbout_HNA.Location = new System.Drawing.Point(139, 19);
            this.LabelFormAbout_HNA.Name = "LabelFormAbout_HNA";
            this.LabelFormAbout_HNA.Size = new System.Drawing.Size(284, 117);
            this.LabelFormAbout_HNA.TabIndex = 3;
            this.LabelFormAbout_HNA.Text = resources.GetString("LabelFormAbout_HNA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 171);
            this.Controls.Add(this.ButOK_HNA);
            this.Controls.Add(this.PictureBox1Img_HNA);
            this.Controls.Add(this.LabelFormAbout_HNA);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1Img_HNA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButOK_HNA;
        private System.Windows.Forms.PictureBox PictureBox1Img_HNA;
        private System.Windows.Forms.Label LabelFormAbout_HNA;
    }
}