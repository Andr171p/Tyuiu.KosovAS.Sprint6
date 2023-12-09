namespace Tyuiu.KosovAS.Sprint6.Task4.V27
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
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_KAS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAS = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KAS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KAS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KAS = new System.Windows.Forms.GroupBox();
            this.labelStop_KAS = new System.Windows.Forms.Label();
            this.labelStart_KAS = new System.Windows.Forms.Label();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxStart_KAS = new System.Windows.Forms.TextBox();
            this.buttonResult_KAS = new System.Windows.Forms.Button();
            this.buttonSave_KAS = new System.Windows.Forms.Button();
            this.buttonInfo_KAS = new System.Windows.Forms.Button();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KAS.SuspendLayout();
            this.groupBoxResult_KAS.SuspendLayout();
            this.groupBoxInput_KAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAS
            // 
            this.groupBoxTask_KAS.Controls.Add(this.textBoxTask_KAS);
            this.groupBoxTask_KAS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAS.Name = "groupBoxTask_KAS";
            this.groupBoxTask_KAS.Size = new System.Drawing.Size(530, 115);
            this.groupBoxTask_KAS.TabIndex = 0;
            this.groupBoxTask_KAS.TabStop = false;
            this.groupBoxTask_KAS.Text = "Условие";
            // 
            // textBoxTask_KAS
            // 
            this.textBoxTask_KAS.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_KAS.Multiline = true;
            this.textBoxTask_KAS.Name = "textBoxTask_KAS";
            this.textBoxTask_KAS.ReadOnly = true;
            this.textBoxTask_KAS.Size = new System.Drawing.Size(521, 92);
            this.textBoxTask_KAS.TabIndex = 0;
            this.textBoxTask_KAS.Text = "Протабулировать функцию:\r\nF(x)=COS(x)/(x+1)-1,3COS(x)+3x\r\nНа заданном диапазоне о" +
    "т -5 до 5, построить график функции и сохранить данные в файл\r\n";
            // 
            // groupBoxResult_KAS
            // 
            this.groupBoxResult_KAS.Controls.Add(this.textBoxResult_KAS);
            this.groupBoxResult_KAS.Location = new System.Drawing.Point(12, 128);
            this.groupBoxResult_KAS.Name = "groupBoxResult_KAS";
            this.groupBoxResult_KAS.Size = new System.Drawing.Size(200, 378);
            this.groupBoxResult_KAS.TabIndex = 1;
            this.groupBoxResult_KAS.TabStop = false;
            this.groupBoxResult_KAS.Text = "Вывод";
            // 
            // textBoxResult_KAS
            // 
            this.textBoxResult_KAS.Location = new System.Drawing.Point(3, 22);
            this.textBoxResult_KAS.Multiline = true;
            this.textBoxResult_KAS.Name = "textBoxResult_KAS";
            this.textBoxResult_KAS.ReadOnly = true;
            this.textBoxResult_KAS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KAS.Size = new System.Drawing.Size(191, 350);
            this.textBoxResult_KAS.TabIndex = 0;
            // 
            // groupBoxInput_KAS
            // 
            this.groupBoxInput_KAS.Controls.Add(this.labelStop_KAS);
            this.groupBoxInput_KAS.Controls.Add(this.labelStart_KAS);
            this.groupBoxInput_KAS.Controls.Add(this.textBoxStop);
            this.groupBoxInput_KAS.Controls.Add(this.textBoxStart_KAS);
            this.groupBoxInput_KAS.Location = new System.Drawing.Point(548, 12);
            this.groupBoxInput_KAS.Name = "groupBoxInput_KAS";
            this.groupBoxInput_KAS.Size = new System.Drawing.Size(276, 115);
            this.groupBoxInput_KAS.TabIndex = 2;
            this.groupBoxInput_KAS.TabStop = false;
            this.groupBoxInput_KAS.Text = "Ввод данных";
            // 
            // labelStop_KAS
            // 
            this.labelStop_KAS.AutoSize = true;
            this.labelStop_KAS.Location = new System.Drawing.Point(123, 39);
            this.labelStop_KAS.Name = "labelStop_KAS";
            this.labelStop_KAS.Size = new System.Drawing.Size(101, 20);
            this.labelStop_KAS.TabIndex = 3;
            this.labelStop_KAS.Text = "Конец шага:";
            // 
            // labelStart_KAS
            // 
            this.labelStart_KAS.AutoSize = true;
            this.labelStart_KAS.Location = new System.Drawing.Point(6, 39);
            this.labelStart_KAS.Name = "labelStart_KAS";
            this.labelStart_KAS.Size = new System.Drawing.Size(102, 20);
            this.labelStart_KAS.TabIndex = 3;
            this.labelStart_KAS.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(127, 62);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop.TabIndex = 4;
            // 
            // textBoxStart_KAS
            // 
            this.textBoxStart_KAS.Location = new System.Drawing.Point(6, 62);
            this.textBoxStart_KAS.Name = "textBoxStart_KAS";
            this.textBoxStart_KAS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_KAS.TabIndex = 3;
            // 
            // buttonResult_KAS
            // 
            this.buttonResult_KAS.BackColor = System.Drawing.Color.Lime;
            this.buttonResult_KAS.Location = new System.Drawing.Point(830, 12);
            this.buttonResult_KAS.Name = "buttonResult_KAS";
            this.buttonResult_KAS.Size = new System.Drawing.Size(116, 59);
            this.buttonResult_KAS.TabIndex = 3;
            this.buttonResult_KAS.Text = "Выполнить";
            this.buttonResult_KAS.UseVisualStyleBackColor = false;
            this.buttonResult_KAS.Click += new System.EventHandler(this.buttonResult_KAS_Click);
            this.buttonResult_KAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MouseDown);
            this.buttonResult_KAS.MouseEnter += new System.EventHandler(this.buttonResult_MouseEnter);
            this.buttonResult_KAS.MouseLeave += new System.EventHandler(this.buttonResult_MouseLeave);
            // 
            // buttonSave_KAS
            // 
            this.buttonSave_KAS.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_KAS.Location = new System.Drawing.Point(830, 74);
            this.buttonSave_KAS.Name = "buttonSave_KAS";
            this.buttonSave_KAS.Size = new System.Drawing.Size(116, 53);
            this.buttonSave_KAS.TabIndex = 4;
            this.buttonSave_KAS.Text = "Сохранить";
            this.buttonSave_KAS.UseVisualStyleBackColor = false;
            this.buttonSave_KAS.Click += new System.EventHandler(this.buttonSave_KAS_Click);
            // 
            // buttonInfo_KAS
            // 
            this.buttonInfo_KAS.BackColor = System.Drawing.Color.Blue;
            this.buttonInfo_KAS.Location = new System.Drawing.Point(952, 74);
            this.buttonInfo_KAS.Name = "buttonInfo_KAS";
            this.buttonInfo_KAS.Size = new System.Drawing.Size(112, 53);
            this.buttonInfo_KAS.TabIndex = 5;
            this.buttonInfo_KAS.Text = "Справка";
            this.buttonInfo_KAS.UseVisualStyleBackColor = false;
            this.buttonInfo_KAS.Click += new System.EventHandler(this.buttonInfo_KAS_Click);
            // 
            // chartFunction
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFunction.Legends.Add(legend6);
            this.chartFunction.Location = new System.Drawing.Point(236, 133);
            this.chartFunction.Name = "chartFunction";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFunction.Series.Add(series6);
            this.chartFunction.Size = new System.Drawing.Size(819, 373);
            this.chartFunction.TabIndex = 6;
            this.chartFunction.Text = "chartFunction";
            title6.Name = "TitleFunc";
            title6.Text = "График функции F(x)";
            this.chartFunction.Titles.Add(title6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 518);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.buttonInfo_KAS);
            this.Controls.Add(this.buttonSave_KAS);
            this.Controls.Add(this.buttonResult_KAS);
            this.Controls.Add(this.groupBoxInput_KAS);
            this.Controls.Add(this.groupBoxResult_KAS);
            this.Controls.Add(this.groupBoxTask_KAS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 27 | Косов А.С";
            this.groupBoxTask_KAS.ResumeLayout(false);
            this.groupBoxTask_KAS.PerformLayout();
            this.groupBoxResult_KAS.ResumeLayout(false);
            this.groupBoxResult_KAS.PerformLayout();
            this.groupBoxInput_KAS.ResumeLayout(false);
            this.groupBoxInput_KAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAS;
        private System.Windows.Forms.TextBox textBoxTask_KAS;
        private System.Windows.Forms.GroupBox groupBoxResult_KAS;
        private System.Windows.Forms.TextBox textBoxResult_KAS;
        private System.Windows.Forms.GroupBox groupBoxInput_KAS;
        private System.Windows.Forms.Label labelStop_KAS;
        private System.Windows.Forms.Label labelStart_KAS;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxStart_KAS;
        private System.Windows.Forms.Button buttonResult_KAS;
        private System.Windows.Forms.Button buttonSave_KAS;
        private System.Windows.Forms.Button buttonInfo_KAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

