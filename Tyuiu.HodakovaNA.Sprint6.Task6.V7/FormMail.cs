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

using Tyuiu.HodakovaNA.Sprint6.Task6.V7.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task6.V7
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
            OpenFileDialogTask_HNA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        
        static string openFilePath;
        
        DataService ds = new DataService();

        private void FormMail_Load(object sender, EventArgs e)
        {

        }

        private void But2Dok_HNA_Click(object sender, EventArgs e)
        {
            
            But1File_HNA.Enabled = true;
        }

        private void But1File_HNA_Click(object sender, EventArgs e)
        {

        }

        private void But4Info_HNA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }


        private void But2Dok_HNA_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_HNA.ToolTipTitle = "Открыть файл";
        }

        private void But1File_HNA_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_HNA.ToolTipTitle = "Выполнить";
        }

        private void But4Info_HNA_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_HNA.ToolTipTitle = "Справка";
        }
    }
}
