using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KosovAS.Sprint6.TaskReview.V29.Lib;

namespace Tyuiu.KosovAS.Sprint6.TaskReview.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonRandomMatrix_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();

                int rows = Convert.ToInt32(textBoxRows_KAS.Text);
                int columns = Convert.ToInt32(textBoxColumns_KAS.Text);
                int[,] matrix = new int[rows, columns];
                int n1 = Convert.ToInt32(textBoxStart_KAS.Text);
                int n2 = Convert.ToInt32(textBoxStop_KAS.Text);

                dataGridViewRandom_KAS.ColumnCount = columns;
                dataGridViewRandom_KAS.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewRandom_KAS.Columns[i].Width = 25;
                }
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewRandom_KAS.Rows[i].Cells[j].Value = rnd.Next(Convert.ToInt32(textBoxStart_KAS.Text), Convert.ToInt32(textBoxStop_KAS.Text));
                    }
                }
                int[,] arrayData = new int[rows, columns];
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        arrayData[r, c] = Convert.ToInt32(dataGridViewRandom_KAS.Rows[r].Cells[c].Value);
                    }
                }
                arrayData = ds.SortColumns(arrayData);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewRandom_KAS.Rows[i].Cells[j].Value = arrayData[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(textBoxRows_KAS.Text);
                int columns = Convert.ToInt32(textBoxColumns_KAS.Text);

                int[,] matrix = new int[rows, columns];

                textBoxResult_KAS.Clear();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridViewRandom_KAS.Rows[i].Cells[j].Value);
                    }
                }

                int n1 = Convert.ToInt32(textBoxStart_KAS.Text);
                int n2 = Convert.ToInt32(textBoxStop_KAS.Text);
                
                int K = Convert.ToInt32(textBoxK_KAS.Text);
                int L = Convert.ToInt32(textBoxL_KAS.Text);

                int R = Convert.ToInt32(textBoxR_KAS.Text);

                textBoxResult_KAS.Text = Convert.ToString(ds.GetMatrix(matrix, n1, n2, K, L, R));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_KAS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRandomMatrix_KAS.BackColor = Color.Blue;
        }

        private void buttonResult_KAS_MouseEnter(object sender, EventArgs e)
        {
            buttonRandomMatrix_KAS.BackColor = Color.Red;

            toolTip.ToolTipTitle = "Подсказка";
        }

        private void buttonResult_KAS_MouseLeave(object sender, EventArgs e)
        {
            buttonRandomMatrix_KAS.BackColor = Color.Lime;
        }

        private void buttonDone_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Подсказка";
        }

        private void buttonInfo_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Справка";
        }

        private void buttonInfo_KAS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
