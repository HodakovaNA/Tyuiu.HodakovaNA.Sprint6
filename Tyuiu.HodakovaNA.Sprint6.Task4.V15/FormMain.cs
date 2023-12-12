using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.HodakovaNA.Sprint6.Task4.V15.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task4.V15
{
    public partial class FormMain_HNA : Form
    {
        public FormMain_HNA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void Lab1Uslovie_HNA_Click(object sender, EventArgs e)
        {

        }

        private void But1Vipolnit_HNA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(TBox1Start_HNA.Text);
                int stopValue = Convert.ToInt32(TBox2Stop_HNA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;


                double[] wait = new double[len];
                wait = ds.GetMassFunction(startValue, stopValue);

                this.Chart1Grafik_HNA.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart1Grafik_HNA.ChartAreas[0].AxisY.Title = "Ось Y";

                TBox3Res_HNA.Text = "";

                Chart1Grafik_HNA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.Chart1Grafik_HNA.Series[0].Points.AddXY(startValue, wait[i]);
                    TBox3Res_HNA.AppendText(wait[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But2Sohranit_HNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы АСОиУб-23-1 Ходакова Надежда Антоновна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void But3Spavka_HNA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V15.txt";
                File.WriteAllText(path, TBox3Res_HNA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранение файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Chart1Grafik_HNA_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_HNA_Load(object sender, EventArgs e)
        {

        }
    }
}
