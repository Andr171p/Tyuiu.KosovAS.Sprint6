namespace Tyuiu.KosovAS.Sprint6.Task0.V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelVar = new System.Windows.Forms.Label();
            this.textBoxVar = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVar
            // 
            this.labelVar.AutoSize = true;
            this.labelVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar.Location = new System.Drawing.Point(65, 255);
            this.labelVar.Name = "labelVar";
            this.labelVar.Size = new System.Drawing.Size(36, 29);
            this.labelVar.TabIndex = 0;
            this.labelVar.Text = "X:";
            // 
            // textBoxVar
            // 
            this.textBoxVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVar.Location = new System.Drawing.Point(123, 249);
            this.textBoxVar.Name = "textBoxVar";
            this.textBoxVar.Size = new System.Drawing.Size(130, 35);
            this.textBoxVar.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(40, 321);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(61, 29);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "F(x):";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(123, 321);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(130, 35);
            this.textBoxResult.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(545, 305);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(191, 51);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 183);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(424, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Формула:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxVar);
            this.Controls.Add(this.labelVar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 1 | Косов А.С";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVar;
        private System.Windows.Forms.TextBox textBoxVar;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

