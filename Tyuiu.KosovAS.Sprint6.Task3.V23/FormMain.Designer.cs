namespace Tyuiu.KosovAS.Sprint6.Task3.V23
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.dataGridViewTask);
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(616, 426);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(310, 395);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "Дана матрица 5 на 5\r\n0 -19  25  34   0\r\n -19 -16   1  -5  34\r\n   1  13  -5 -17  -" +
    "5\r\n   3  -9 -15  -1   0\r\n   1  20  15  -5  31\r\nОтсортировать второй столбец матр" +
    "ицы по возврастанию\r\n\r\n";
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.ColumnHeadersVisible = false;
            this.dataGridViewTask.Location = new System.Drawing.Point(322, 25);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowHeadersVisible = false;
            this.dataGridViewTask.RowHeadersWidth = 62;
            this.dataGridViewTask.RowTemplate.Height = 28;
            this.dataGridViewTask.Size = new System.Drawing.Size(286, 395);
            this.dataGridViewTask.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Location = new System.Drawing.Point(634, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(336, 336);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 28);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(93, 20);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Lime;
            this.buttonResult.Location = new System.Drawing.Point(806, 354);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(164, 54);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            this.buttonResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MouseDown);
            this.buttonResult.MouseEnter += new System.EventHandler(this.buttonResult_MouseEnter);
            this.buttonResult.MouseLeave += new System.EventHandler(this.buttonResult_MoudeLeave);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInfo.Location = new System.Drawing.Point(738, 354);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(62, 54);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "?";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            this.dataGridViewResult.Location = new System.Drawing.Point(10, 51);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 62;
            this.dataGridViewResult.RowTemplate.Height = 28;
            this.dataGridViewResult.Size = new System.Drawing.Size(320, 279);
            this.dataGridViewResult.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTask);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 23 | Косов А.С";
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}

