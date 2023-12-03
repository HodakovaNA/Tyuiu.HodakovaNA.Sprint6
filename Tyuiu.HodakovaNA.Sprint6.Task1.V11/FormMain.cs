using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.HodakovaNA.Sprint6.Task1.V11.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task1.V11
{
    public partial class FormMain_HNA : Form
    {
        public FormMain_HNA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ImgBox_HNA_Click(object sender, EventArgs e)
        {
            ImgBox_HNA.Image = Image.FromFile(@"C:\Users\User\source\repos\Tyuiu.HodakovaNA.Sprint6\Tyuiu.HodakovaNA.Sprint6.Task1.V11\Task1.png");
        }

        private void TBoxStart_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBoxFinish_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void But1Spravka_HNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, выполнила студент группы АСОиУб-23-1 Ходакова Надежда Антоновна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GBox3_HNA_Enter(object sender, EventArgs e)
        {
                ////
        }

        private void TBoxRes_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void But2Vipolnit_HNA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(TBoxStart_HNA.Text);
                int stopValue = Convert.ToInt32(TBoxFinish_HNA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                TBoxRes_HNA.Text = "";
                TBoxRes_HNA.AppendText("---------+--------------" + Environment.NewLine);
                TBoxRes_HNA.AppendText("|     X  |     f(x)    |" + Environment.NewLine);
                TBoxRes_HNA.AppendText("---------+--------------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |    {1,6:f2}   |", startValue, valueArray[i]);
                    TBoxRes_HNA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                TBoxRes_HNA.AppendText("---------+--------------" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
