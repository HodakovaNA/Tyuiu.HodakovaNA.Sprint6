using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.HodakovaNA.Sprint6.Task3.V16.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task3.V16
{
    public partial class FormMain_HNA : Form
    {
        public FormMain_HNA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { 14, 1, -3, 1, 10 },
                                        { 7, -3, 5, -4, 0 },
                                        { -10, -19, -18, -9, 19 },
                                        { -2, -2, -16, 2, -17 },
                                        { -16, 9, 5, -10, 16 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void DGridViewTable_HNA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBoxRes_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void But1Info_HNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, выполнила студент группы АСОиУб-23-1 Ходакова Надежда Антоновна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void But2Vicheslit_HNA_Click(object sender, EventArgs e)
        {

        }

        private void But2Vicheslit_HNA_Click_1(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            DGridViewTable_HNA.ColumnCount = columns;
            DGridViewTable_HNA.RowCount = rows;

            for (int j = 0; j < columns; j++)
            {
                DGridViewTable_HNA.Columns[j].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DGridViewTable_HNA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
