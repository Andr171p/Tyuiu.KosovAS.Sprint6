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

using Tyuiu.KosovAS.Sprint6.Task7.V20.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KAS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KAS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string OpenFilePath;

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

        private void buttonResult_KAS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(OpenFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KAS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_KAS.Enabled = true;
        }

        private void buttonOpenFile_KAS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAS.ShowDialog();
            OpenFilePath = openFileDialogTask_KAS.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(OpenFilePath);

            dataGridViewIn_KAS.ColumnCount = columns;
            dataGridViewIn_KAS.RowCount = rows;

            dataGridViewOut_KAS.ColumnCount = columns;
            dataGridViewOut_KAS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KAS.Columns[i].Width = 25;
                dataGridViewOut_KAS.Columns[i].Width = 45;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KAS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(OpenFilePath));
            buttonResult_KAS.Enabled = true;
        }

        private void buttonSaveFile_KAS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KAS.FileName = "OutPutFileTask7V20.csv";
            saveFileDialogMatrix_KAS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KAS.ShowDialog();

            string path = saveFileDialogMatrix_KAS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KAS.RowCount;
            int columns = dataGridViewOut_KAS.ColumnCount;

            string str = "";

            for (int  i = 0; i < rows; i++)
            {
                for (int  j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KAS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KAS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Открыть файл";
        }

        private void buttonResult_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Сохранить в файл";
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
