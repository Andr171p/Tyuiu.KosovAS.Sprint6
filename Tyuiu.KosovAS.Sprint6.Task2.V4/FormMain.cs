using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KosovAS.Sprint6.Task2.V4.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult.Titles.Add("График функции F(x)");

                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResult.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-3 Косов Андрей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Red;
        }

        private void buttonResult_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult.BackColor = Color.Blue;
        }

        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Lime;
        }
    }
}
