using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.HodakovaNA.Sprint6.Task0.V21.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void TBoxA_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBoxB_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBoxC_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBoxRes_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSpravka_HNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, выполнила студент группы АСОиУб-23-1 Ходакова Надежда Антоновна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button1Vipolnit_HNA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TBoxRes_HNA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TBoxA_HNA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImgBox_HNA_Click(object sender, EventArgs e)
        {
            ImgBox_HNA.Image = Image.FromFile(@"C:\Users\User\source\repos\Tyuiu.HodakovaNA.Sprint6\Tyuiu.HodakovaNA.Sprint6.Task0.V21\Task0.png");
        }
    }
}
