namespace Tyuiu.KosovAS.Sprint6.Task6.V30
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
            this.groupBoxTask_KAS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile_KAS = new System.Windows.Forms.Button();
            this.buttonResult_KAS = new System.Windows.Forms.Button();
            this.buttonInfo_KAS = new System.Windows.Forms.Button();
            this.openFileDialogTask_KAS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxIn_KAS = new System.Windows.Forms.TextBox();
            this.textBoxOut_KAS = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KAS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAS
            // 
            this.groupBoxTask_KAS.Controls.Add(this.textBoxTask_KAS);
            this.groupBoxTask_KAS.Location = new System.Drawing.Point(12, 100);
            this.groupBoxTask_KAS.Name = "groupBoxTask_KAS";
            this.groupBoxTask_KAS.Size = new System.Drawing.Size(1006, 79);
            this.groupBoxTask_KAS.TabIndex = 3;
            this.groupBoxTask_KAS.TabStop = false;
            this.groupBoxTask_KAS.Text = "Условие";
            // 
            // textBoxTask_KAS
            // 
            this.textBoxTask_KAS.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_KAS.Multiline = true;
            this.textBoxTask_KAS.Name = "textBoxTask_KAS";
            this.textBoxTask_KAS.ReadOnly = true;
            this.textBoxTask_KAS.Size = new System.Drawing.Size(994, 48);
            this.textBoxTask_KAS.TabIndex = 4;
            this.textBoxTask_KAS.Text = resources.GetString("textBoxTask_KAS.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIn_KAS);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOut_KAS);
            this.groupBox2.Location = new System.Drawing.Point(529, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 302);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // buttonOpenFile_KAS
            // 
            this.buttonOpenFile_KAS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_KAS.Name = "buttonOpenFile_KAS";
            this.buttonOpenFile_KAS.Size = new System.Drawing.Size(131, 82);
            this.buttonOpenFile_KAS.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonOpenFile_KAS, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_KAS.UseVisualStyleBackColor = true;
            // 
            // buttonResult_KAS
            // 
            this.buttonResult_KAS.Location = new System.Drawing.Point(176, 12);
            this.buttonResult_KAS.Name = "buttonResult_KAS";
            this.buttonResult_KAS.Size = new System.Drawing.Size(131, 82);
            this.buttonResult_KAS.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonResult_KAS, "Выполнить\r\nПроизводит поиск четвёртого элемента в каждой строке\r\n");
            this.buttonResult_KAS.UseVisualStyleBackColor = true;
            this.buttonResult_KAS.Click += new System.EventHandler(this.buttonResult_KAS_Click);
            // 
            // buttonInfo_KAS
            // 
            this.buttonInfo_KAS.Location = new System.Drawing.Point(887, 12);
            this.buttonInfo_KAS.Name = "buttonInfo_KAS";
            this.buttonInfo_KAS.Size = new System.Drawing.Size(131, 82);
            this.buttonInfo_KAS.TabIndex = 8;
            this.toolTip.SetToolTip(this.buttonInfo_KAS, "Показывает данные о разработчике\r\n");
            this.buttonInfo_KAS.UseVisualStyleBackColor = true;
            // 
            // openFileDialogTask_KAS
            // 
            this.openFileDialogTask_KAS.FileName = "openFileDialogTask_KAS";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // textBoxIn_KAS
            // 
            this.textBoxIn_KAS.Location = new System.Drawing.Point(6, 25);
            this.textBoxIn_KAS.Multiline = true;
            this.textBoxIn_KAS.Name = "textBoxIn_KAS";
            this.textBoxIn_KAS.ReadOnly = true;
            this.textBoxIn_KAS.Size = new System.Drawing.Size(499, 271);
            this.textBoxIn_KAS.TabIndex = 9;
            // 
            // textBoxOut_KAS
            // 
            this.textBoxOut_KAS.Location = new System.Drawing.Point(6, 25);
            this.textBoxOut_KAS.Multiline = true;
            this.textBoxOut_KAS.Name = "textBoxOut_KAS";
            this.textBoxOut_KAS.ReadOnly = true;
            this.textBoxOut_KAS.Size = new System.Drawing.Size(471, 271);
            this.textBoxOut_KAS.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 493);
            this.Controls.Add(this.buttonInfo_KAS);
            this.Controls.Add(this.buttonResult_KAS);
            this.Controls.Add(this.buttonOpenFile_KAS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTask_KAS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 30 | Косов А.С";
            this.groupBoxTask_KAS.ResumeLayout(false);
            this.groupBoxTask_KAS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTask_KAS;
        private System.Windows.Forms.TextBox textBoxTask_KAS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOpenFile_KAS;
        private System.Windows.Forms.Button buttonResult_KAS;
        private System.Windows.Forms.Button buttonInfo_KAS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAS;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxIn_KAS;
        private System.Windows.Forms.TextBox textBoxOut_KAS;
    }
}

