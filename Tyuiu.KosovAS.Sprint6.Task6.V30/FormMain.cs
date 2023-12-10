using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KosovAS.Sprint6.Task6.V30.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string OpenFilePath;

        private void buttonResult_KAS_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOut_KAS.Text = ds.CollectTextFromFile(str, OpenFilePath);
        }
    }
}
