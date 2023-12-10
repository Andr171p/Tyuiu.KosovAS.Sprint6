namespace Tyuiu.KosovAS.Sprint6.Task5.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KAS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAS = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KAS = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonResult_KAS = new System.Windows.Forms.Button();
            this.buttonSave_KAS = new System.Windows.Forms.Button();
            this.buttonInfo_KAS = new System.Windows.Forms.Button();
            this.dataGridViewResult_KAS = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_KAS.SuspendLayout();
            this.groupBoxResult_KAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAS
            // 
            this.groupBoxTask_KAS.Controls.Add(this.textBoxTask_KAS);
            this.groupBoxTask_KAS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAS.Name = "groupBoxTask_KAS";
            this.groupBoxTask_KAS.Size = new System.Drawing.Size(427, 140);
            this.groupBoxTask_KAS.TabIndex = 0;
            this.groupBoxTask_KAS.TabStop = false;
            this.groupBoxTask_KAS.Text = "Условие";
            // 
            // textBoxTask_KAS
            // 
            this.textBoxTask_KAS.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_KAS.Multiline = true;
            this.textBoxTask_KAS.Name = "textBoxTask_KAS";
            this.textBoxTask_KAS.ReadOnly = true;
            this.textBoxTask_KAS.Size = new System.Drawing.Size(415, 109);
            this.textBoxTask_KAS.TabIndex = 1;
            this.textBoxTask_KAS.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести в dataGridView не нулевые" +
    " значения и построить диаграму по этим значениям.\r\n";
            // 
            // groupBoxResult_KAS
            // 
            this.groupBoxResult_KAS.Controls.Add(this.dataGridViewResult_KAS);
            this.groupBoxResult_KAS.Location = new System.Drawing.Point(12, 158);
            this.groupBoxResult_KAS.Name = "groupBoxResult_KAS";
            this.groupBoxResult_KAS.Size = new System.Drawing.Size(200, 330);
            this.groupBoxResult_KAS.TabIndex = 1;
            this.groupBoxResult_KAS.TabStop = false;
            this.groupBoxResult_KAS.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction.Legends.Add(legend4);
            this.chartFunction.Location = new System.Drawing.Point(229, 158);
            this.chartFunction.Name = "chartFunction";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction.Series.Add(series4);
            this.chartFunction.Size = new System.Drawing.Size(813, 330);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "chartFunction";
            // 
            // buttonResult_KAS
            // 
            this.buttonResult_KAS.BackColor = System.Drawing.Color.Lime;
            this.buttonResult_KAS.Location = new System.Drawing.Point(445, 12);
            this.buttonResult_KAS.Name = "buttonResult_KAS";
            this.buttonResult_KAS.Size = new System.Drawing.Size(159, 58);
            this.buttonResult_KAS.TabIndex = 3;
            this.buttonResult_KAS.Text = "Выполнить";
            this.buttonResult_KAS.UseVisualStyleBackColor = false;
            this.buttonResult_KAS.Click += new System.EventHandler(this.buttonResult_KAS_Click);
            // 
            // buttonSave_KAS
            // 
            this.buttonSave_KAS.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_KAS.Location = new System.Drawing.Point(445, 88);
            this.buttonSave_KAS.Name = "buttonSave_KAS";
            this.buttonSave_KAS.Size = new System.Drawing.Size(159, 58);
            this.buttonSave_KAS.TabIndex = 4;
            this.buttonSave_KAS.Text = "Открыть файл";
            this.buttonSave_KAS.UseVisualStyleBackColor = false;
            this.buttonSave_KAS.Click += new System.EventHandler(this.buttonSave_KAS_Click);
            // 
            // buttonInfo_KAS
            // 
            this.buttonInfo_KAS.BackColor = System.Drawing.Color.Blue;
            this.buttonInfo_KAS.Location = new System.Drawing.Point(610, 88);
            this.buttonInfo_KAS.Name = "buttonInfo_KAS";
            this.buttonInfo_KAS.Size = new System.Drawing.Size(159, 58);
            this.buttonInfo_KAS.TabIndex = 5;
            this.buttonInfo_KAS.Text = "Справка";
            this.buttonInfo_KAS.UseVisualStyleBackColor = false;
            this.buttonInfo_KAS.Click += new System.EventHandler(this.buttonInfo_KAS_Click);
            // 
            // dataGridViewResult_KAS
            // 
            this.dataGridViewResult_KAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewResult_KAS.Name = "dataGridViewResult_KAS";
            this.dataGridViewResult_KAS.RowHeadersVisible = false;
            this.dataGridViewResult_KAS.RowHeadersWidth = 62;
            this.dataGridViewResult_KAS.RowTemplate.Height = 28;
            this.dataGridViewResult_KAS.Size = new System.Drawing.Size(191, 302);
            this.dataGridViewResult_KAS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 500);
            this.Controls.Add(this.buttonInfo_KAS);
            this.Controls.Add(this.buttonSave_KAS);
            this.Controls.Add(this.buttonResult_KAS);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.groupBoxResult_KAS);
            this.Controls.Add(this.groupBoxTask_KAS);
            this.Name = "FormMain";
            this.groupBoxTask_KAS.ResumeLayout(false);
            this.groupBoxTask_KAS.PerformLayout();
            this.groupBoxResult_KAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAS;
        private System.Windows.Forms.TextBox textBoxTask_KAS;
        private System.Windows.Forms.GroupBox groupBoxResult_KAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Button buttonResult_KAS;
        private System.Windows.Forms.Button buttonSave_KAS;
        private System.Windows.Forms.Button buttonInfo_KAS;
        private System.Windows.Forms.DataGridView dataGridViewResult_KAS;
    }
}

