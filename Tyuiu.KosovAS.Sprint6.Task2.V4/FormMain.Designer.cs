namespace Tyuiu.KosovAS.Sprint6.Task2.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxStartValue = new System.Windows.Forms.TextBox();
            this.textBoxStopValue = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(422, 278);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(410, 247);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции\r\nF(x)=(5x+2,5)/(SIN(" +
    "x)+2)+2x+2";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelStop);
            this.groupBoxInput.Controls.Add(this.labelStart);
            this.groupBoxInput.Controls.Add(this.textBoxStopValue);
            this.groupBoxInput.Controls.Add(this.textBoxStartValue);
            this.groupBoxInput.Controls.Add(this.textBox1);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 306);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(246, 132);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxStartValue
            // 
            this.textBoxStartValue.Location = new System.Drawing.Point(6, 77);
            this.textBoxStartValue.Name = "textBoxStartValue";
            this.textBoxStartValue.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartValue.TabIndex = 1;
            // 
            // textBoxStopValue
            // 
            this.textBoxStopValue.Location = new System.Drawing.Point(136, 77);
            this.textBoxStopValue.Name = "textBoxStopValue";
            this.textBoxStopValue.Size = new System.Drawing.Size(100, 26);
            this.textBoxStopValue.TabIndex = 2;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(6, 54);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(102, 20);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Старт шага:";
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(132, 54);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(101, 20);
            this.labelStop.TabIndex = 3;
            this.labelStop.Text = "Конец шага:";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelLine);
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Controls.Add(this.chartResult);
            this.groupBoxResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxResult.Location = new System.Drawing.Point(450, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(591, 426);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Fx});
            this.dataGridViewResult.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 62;
            this.dataGridViewResult.RowTemplate.Height = 28;
            this.dataGridViewResult.Size = new System.Drawing.Size(153, 370);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Fx
            // 
            this.Fx.HeaderText = "F(X)";
            this.Fx.MinimumWidth = 8;
            this.Fx.Name = "Fx";
            this.Fx.Width = 50;
            // 
            // chartResult
            // 
            chartArea6.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartResult.Legends.Add(legend6);
            this.chartResult.Location = new System.Drawing.Point(171, 50);
            this.chartResult.Name = "chartResult";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartResult.Series.Add(series6);
            this.chartResult.Size = new System.Drawing.Size(420, 370);
            this.chartResult.TabIndex = 1;
            this.chartResult.Text = "chart1";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Lime;
            this.buttonResult.Location = new System.Drawing.Point(281, 306);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(153, 61);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            this.buttonResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MouseDown);
            this.buttonResult.MouseEnter += new System.EventHandler(this.buttonResult_MouseEnter);
            this.buttonResult.MouseLeave += new System.EventHandler(this.buttonResult_MouseLeave);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Silver;
            this.buttonInfo.Location = new System.Drawing.Point(281, 371);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(153, 61);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 27);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(77, 20);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Таблица:";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(167, 22);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(72, 20);
            this.labelLine.TabIndex = 3;
            this.labelLine.Text = "График:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Косов А.С";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxStartValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxStopValue;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelResult;
    }
}

