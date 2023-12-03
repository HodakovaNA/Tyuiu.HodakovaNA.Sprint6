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
    }
}
