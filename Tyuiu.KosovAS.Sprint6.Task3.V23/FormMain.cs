using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KosovAS.Sprint6.Task3.V23.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task3.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { 0, -19, 25, 34, 0 },
                                        {-19, -16, 1, -5, 34 },
                                        {1, 13, -5, -17, -5 },
                                        {3, -9, -15, -1, 0 },
                                        {1, 20, 15, -5, 31 }};

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(ds.Calculate(matrix)[i, j]);
                }
            }
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewTask.ColumnCount = columns;
            dataGridViewTask.RowCount = rows;

            for (int i = 0;  i < columns; i++)
            {
                dataGridViewTask.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewTask.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-23-3 Косов Андрей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult.BackColor = Color.Blue;
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Red;
        }

        private void buttonResult_MoudeLeave(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Lime;
        }
    }
}
