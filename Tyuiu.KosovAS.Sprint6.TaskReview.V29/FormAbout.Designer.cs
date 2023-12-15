namespace Tyuiu.KosovAS.Sprint6.TaskReview.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxInfo_KAS = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KAS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInfo_KAS
            // 
            this.pictureBoxInfo_KAS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo_KAS.Image")));
            this.pictureBoxInfo_KAS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInfo_KAS.Name = "pictureBoxInfo_KAS";
            this.pictureBoxInfo_KAS.Size = new System.Drawing.Size(301, 396);
            this.pictureBoxInfo_KAS.TabIndex = 0;
            this.pictureBoxInfo_KAS.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 140);
            this.label1.TabIndex = 1;
            this.label1.Text = "Разработчик: Косов А.С\r\nГруппа: АСОиУБ-23-3\r\n\r\nПрограмма разработана в рамках изу" +
    "чения языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа ци" +
    "фровых технологий (с) 2023\r\n";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxInfo_KAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfo_KAS;
        private System.Windows.Forms.Label label1;
    }
}