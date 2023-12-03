using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.HodakovaNA.Sprint6.Task2.V14.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task2.V14
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

        private void ImgBox_HNA_Click(object sender, EventArgs e)
        {
            ImgBox_HNA.Image = Image.FromFile(@"C:\Users\User\source\repos\Tyuiu.HodakovaNA.Sprint6\Tyuiu.HodakovaNA.Sprint6.Task2.V14\Task2.png");
        }

        private void TBoxStart_HNA_TextChanged(object sender, EventArgs e)
        {
            ///
        }

        private void But1Spravka_HNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, выполнила студент группы АСОиУб-23-1 Ходакова Надежда Антоновна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void But2Vipolnit_HNA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = Convert.ToInt32(TBoxStart_HNA.Text);
                int stopValue = Convert.ToInt32(TBoxFinish_HNA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.Grafik_HNA.Titles.Add("График функции (5 - 3 * x) + ((1 + Math.Sin(x)) / (2 * x - 0.5)) ");
                this.Grafik_HNA.ChartAreas[0].AxisX.Title = "Ось X";
                this.Grafik_HNA.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.DGridV_HNA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.Grafik_HNA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But2Vipolnit_HNA_MauseEntyer(object sender, EventArgs e)
        {
            But2Vipolnit_HNA.BackColor = Color.Red;
        }

        private void But2Vipolnit_HNA_MauseLeave(object sender, EventArgs e)
        {
            But2Vipolnit_HNA.BackColor = Color.Green;
        }

        private void But2Vipolnit_HNA_MauseDown(object sender, MouseEventArgs e)
        {
            But2Vipolnit_HNA.BackColor = Color.Blue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
