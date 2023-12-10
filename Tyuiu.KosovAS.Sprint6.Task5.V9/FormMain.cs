using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KosovAS.Sprint6.Task5.V9.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\andre\source\repos\Tyuiu.KosovAS.Sprint6\DataTask5\InPutFileTask5V9.txt";
        private void buttonResult_KAS_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KAS.ColumnCount = 2;
            dataGridViewResult_KAS.Columns[0].Width = 20;
            dataGridViewResult_KAS.Columns[1].Width = 50;

            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass =ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_KAS.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartFunction.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonSave_KAS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_KAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-3 Косов Андрей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
