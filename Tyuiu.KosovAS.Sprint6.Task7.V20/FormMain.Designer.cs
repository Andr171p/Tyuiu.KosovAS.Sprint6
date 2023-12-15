namespace Tyuiu.KosovAS.Sprint6.Task7.V20
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_KAS = new System.Windows.Forms.Button();
            this.buttonResult_KAS = new System.Windows.Forms.Button();
            this.buttonInfo_KAS = new System.Windows.Forms.Button();
            this.groupBoxTask_KAS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAS = new System.Windows.Forms.TextBox();
            this.groupBoxIn_KAS = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_KAS = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_KAS = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_KAS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_KAS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_KAS = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveFile_KAS = new System.Windows.Forms.Button();
            this.groupBoxTask_KAS.SuspendLayout();
            this.groupBoxIn_KAS.SuspendLayout();
            this.groupBoxOut_KAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KAS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile_KAS
            // 
            this.buttonOpenFile_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KAS.Image")));
            this.buttonOpenFile_KAS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_KAS.Name = "buttonOpenFile_KAS";
            this.buttonOpenFile_KAS.Size = new System.Drawing.Size(123, 79);
            this.buttonOpenFile_KAS.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonOpenFile_KAS, "Выберите нужный файл");
            this.buttonOpenFile_KAS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAS.Click += new System.EventHandler(this.buttonOpenFile_KAS_Click);
            this.buttonOpenFile_KAS.MouseEnter += new System.EventHandler(this.buttonOpenFile_KAS_MouseEnter);
            // 
            // buttonResult_KAS
            // 
            this.buttonResult_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonResult_KAS.Image")));
            this.buttonResult_KAS.Location = new System.Drawing.Point(157, 12);
            this.buttonResult_KAS.Name = "buttonResult_KAS";
            this.buttonResult_KAS.Size = new System.Drawing.Size(123, 79);
            this.buttonResult_KAS.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonResult_KAS, "Запускает программу\r\n");
            this.buttonResult_KAS.UseVisualStyleBackColor = true;
            this.buttonResult_KAS.Click += new System.EventHandler(this.buttonResult_KAS_Click);
            this.buttonResult_KAS.MouseEnter += new System.EventHandler(this.buttonResult_KAS_MouseEnter);
            // 
            // buttonInfo_KAS
            // 
            this.buttonInfo_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KAS.Image")));
            this.buttonInfo_KAS.Location = new System.Drawing.Point(896, 12);
            this.buttonInfo_KAS.Name = "buttonInfo_KAS";
            this.buttonInfo_KAS.Size = new System.Drawing.Size(123, 79);
            this.buttonInfo_KAS.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonInfo_KAS, "Информация о приложении\r\n");
            this.buttonInfo_KAS.UseVisualStyleBackColor = true;
            this.buttonInfo_KAS.Click += new System.EventHandler(this.buttonInfo_KAS_Click);
            this.buttonInfo_KAS.MouseEnter += new System.EventHandler(this.buttonInfo_KAS_MouseEnter);
            // 
            // groupBoxTask_KAS
            // 
            this.groupBoxTask_KAS.Controls.Add(this.textBoxTask_KAS);
            this.groupBoxTask_KAS.Location = new System.Drawing.Point(12, 97);
            this.groupBoxTask_KAS.Name = "groupBoxTask_KAS";
            this.groupBoxTask_KAS.Size = new System.Drawing.Size(1007, 100);
            this.groupBoxTask_KAS.TabIndex = 3;
            this.groupBoxTask_KAS.TabStop = false;
            this.groupBoxTask_KAS.Text = "Условия";
            // 
            // textBoxTask_KAS
            // 
            this.textBoxTask_KAS.Location = new System.Drawing.Point(3, 22);
            this.textBoxTask_KAS.Multiline = true;
            this.textBoxTask_KAS.Name = "textBoxTask_KAS";
            this.textBoxTask_KAS.ReadOnly = true;
            this.textBoxTask_KAS.Size = new System.Drawing.Size(998, 72);
            this.textBoxTask_KAS.TabIndex = 0;
            this.textBoxTask_KAS.Text = resources.GetString("textBoxTask_KAS.Text");
            // 
            // groupBoxIn_KAS
            // 
            this.groupBoxIn_KAS.Controls.Add(this.dataGridViewIn_KAS);
            this.groupBoxIn_KAS.Location = new System.Drawing.Point(12, 203);
            this.groupBoxIn_KAS.Name = "groupBoxIn_KAS";
            this.groupBoxIn_KAS.Size = new System.Drawing.Size(502, 288);
            this.groupBoxIn_KAS.TabIndex = 4;
            this.groupBoxIn_KAS.TabStop = false;
            this.groupBoxIn_KAS.Text = "Ввод данных";
            // 
            // groupBoxOut_KAS
            // 
            this.groupBoxOut_KAS.Controls.Add(this.dataGridViewOut_KAS);
            this.groupBoxOut_KAS.Location = new System.Drawing.Point(520, 203);
            this.groupBoxOut_KAS.Name = "groupBoxOut_KAS";
            this.groupBoxOut_KAS.Size = new System.Drawing.Size(499, 288);
            this.groupBoxOut_KAS.TabIndex = 5;
            this.groupBoxOut_KAS.TabStop = false;
            this.groupBoxOut_KAS.Text = "Вывод данных";
            // 
            // dataGridViewIn_KAS
            // 
            this.dataGridViewIn_KAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_KAS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewIn_KAS.Name = "dataGridViewIn_KAS";
            this.dataGridViewIn_KAS.RowHeadersVisible = false;
            this.dataGridViewIn_KAS.RowHeadersWidth = 62;
            this.dataGridViewIn_KAS.RowTemplate.Height = 28;
            this.dataGridViewIn_KAS.Size = new System.Drawing.Size(493, 260);
            this.dataGridViewIn_KAS.TabIndex = 0;
            // 
            // dataGridViewOut_KAS
            // 
            this.dataGridViewOut_KAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_KAS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewOut_KAS.Name = "dataGridViewOut_KAS";
            this.dataGridViewOut_KAS.RowHeadersVisible = false;
            this.dataGridViewOut_KAS.RowHeadersWidth = 62;
            this.dataGridViewOut_KAS.RowTemplate.Height = 28;
            this.dataGridViewOut_KAS.Size = new System.Drawing.Size(490, 260);
            this.dataGridViewOut_KAS.TabIndex = 1;
            // 
            // openFileDialogTask_KAS
            // 
            this.openFileDialogTask_KAS.FileName = "openFileDialogTask_KAS";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonSaveFile_KAS
            // 
            this.buttonSaveFile_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_KAS.Image")));
            this.buttonSaveFile_KAS.Location = new System.Drawing.Point(303, 12);
            this.buttonSaveFile_KAS.Name = "buttonSaveFile_KAS";
            this.buttonSaveFile_KAS.Size = new System.Drawing.Size(123, 79);
            this.buttonSaveFile_KAS.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonSaveFile_KAS, "Сохраняет результат в файл\r\n");
            this.buttonSaveFile_KAS.UseVisualStyleBackColor = true;
            this.buttonSaveFile_KAS.Click += new System.EventHandler(this.buttonSaveFile_KAS_Click);
            this.buttonSaveFile_KAS.MouseEnter += new System.EventHandler(this.buttonSaveFile_KAS_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 503);
            this.Controls.Add(this.buttonSaveFile_KAS);
            this.Controls.Add(this.groupBoxOut_KAS);
            this.Controls.Add(this.groupBoxIn_KAS);
            this.Controls.Add(this.groupBoxTask_KAS);
            this.Controls.Add(this.buttonInfo_KAS);
            this.Controls.Add(this.buttonResult_KAS);
            this.Controls.Add(this.buttonOpenFile_KAS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 20 | Косов А.С";
            this.groupBoxTask_KAS.ResumeLayout(false);
            this.groupBoxTask_KAS.PerformLayout();
            this.groupBoxIn_KAS.ResumeLayout(false);
            this.groupBoxOut_KAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_KAS;
        private System.Windows.Forms.Button buttonResult_KAS;
        private System.Windows.Forms.Button buttonInfo_KAS;
        private System.Windows.Forms.GroupBox groupBoxTask_KAS;
        private System.Windows.Forms.TextBox textBoxTask_KAS;
        private System.Windows.Forms.GroupBox groupBoxIn_KAS;
        private System.Windows.Forms.GroupBox groupBoxOut_KAS;
        private System.Windows.Forms.DataGridView dataGridViewIn_KAS;
        private System.Windows.Forms.DataGridView dataGridViewOut_KAS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAS;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KAS;
        private System.Windows.Forms.Button buttonSaveFile_KAS;
    }
}

