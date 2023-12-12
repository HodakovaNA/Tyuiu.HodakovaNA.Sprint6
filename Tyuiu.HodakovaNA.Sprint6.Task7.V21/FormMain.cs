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

using Tyuiu.HodakovaNA.Sprint6.Task7.V21.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            OpenFileDialogTask_HNA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            OpenFileDialogTask_HNA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void TBox2Vivod_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void GBox3Left_HNA_Enter(object sender, EventArgs e)
        {

        }

        private void GBox4Right_HNA_Enter(object sender, EventArgs e)
        {

        }

        private void Lib1Uslovie_HNA_Click(object sender, EventArgs e)
        {

        }

        private void But1File_HNA_Click(object sender, EventArgs e)
        {
            OpenFileDialogTask_HNA.ShowDialog();
            openFilePath = OpenFileDialogTask_HNA.FileName;
            
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            DGridV1Vvod_HNA.ColumnCount = columns;
            DGridV1Vvod_HNA.RowCount = rows;
            DGridV2Vivod_HNA.ColumnCount = columns;
            DGridV2Vivod_HNA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                DGridV1Vvod_HNA.Columns[i].Width = 25;
                DGridV2Vivod_HNA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    DGridV1Vvod_HNA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            But2Dok_HNA.Enabled = true;
        }

        private void GBox2Top_HNA_Enter(object sender, EventArgs e)
        {

        }

        private void GBox1Top_HNA_Enter(object sender, EventArgs e)
        {

        }

        private void TBox1Vvod_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void But2Dok_HNA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    DGridV2Vivod_HNA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            But3Sohr_HNA.Enabled = true;
        }

        private void But4Info_HNA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void But3Sohr_HNA_Click(object sender, EventArgs e)
        {
            SaveFileDialogTask_HNA.FileName = "OutPutFileTask7.csv";
            SaveFileDialogTask_HNA.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialogTask_HNA.ShowDialog();

            string path = SaveFileDialogTask_HNA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = DGridV2Vivod_HNA.RowCount;
            int columns = DGridV2Vivod_HNA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + DGridV2Vivod_HNA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + DGridV2Vivod_HNA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DGridV1Vvod_HNA.ColumnCount = 38;
            DGridV2Vivod_HNA.ColumnCount = 38;

            DGridV1Vvod_HNA.RowCount = 38;
            DGridV2Vivod_HNA.RowCount = 38;

            // panelLeft_KDR.Width = this.Width / 2;

            for (int i = 0; i < 38; i++)
            {
                DGridV1Vvod_HNA.Columns[i].Width = 19;
                DGridV2Vivod_HNA.Columns[i].Width = 19;
            }
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void DGridV1Vvod_HNA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGridV2Vivod_HNA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void But1File_HNA_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_HNA.ToolTipTitle = "Открыть файл";
        }

        private void But2Dok_HNA_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_HNA.ToolTipTitle = "Выполнить";
        }

        private void But3Sohr_HNA_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_HNA.ToolTipTitle = "Сохранить";
        }

        private void But4Info_HNA_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_HNA.ToolTipTitle = "Справка";
        }

    }
}
