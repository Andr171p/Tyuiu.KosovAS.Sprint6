using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KosovAS.Sprint6.Task0.V1.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task0.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVar.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
