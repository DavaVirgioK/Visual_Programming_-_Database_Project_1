namespace Dava_Virgio_Kertawijaya_00000056848_IS431_B_UTS
{
    partial class Form1
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
            this.labelInput = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.labelTotalOutput = new System.Windows.Forms.Label();
            this.labelGradeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(27, 25);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(105, 16);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Banyaknya Nilai";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(27, 383);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(38, 16);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(27, 415);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(45, 16);
            this.labelGrade.TabIndex = 2;
            this.labelGrade.Text = "Grade";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(155, 22);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(113, 22);
            this.textBoxInput.TabIndex = 3;
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(30, 66);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(238, 28);
            this.buttonProses.TabIndex = 4;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(30, 112);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(238, 247);
            this.richTextBoxOutput.TabIndex = 5;
            this.richTextBoxOutput.Text = "";
            // 
            // labelTotalOutput
            // 
            this.labelTotalOutput.AutoSize = true;
            this.labelTotalOutput.Location = new System.Drawing.Point(125, 383);
            this.labelTotalOutput.Name = "labelTotalOutput";
            this.labelTotalOutput.Size = new System.Drawing.Size(0, 16);
            this.labelTotalOutput.TabIndex = 6;
            // 
            // labelGradeOutput
            // 
            this.labelGradeOutput.AutoSize = true;
            this.labelGradeOutput.Location = new System.Drawing.Point(125, 415);
            this.labelGradeOutput.Name = "labelGradeOutput";
            this.labelGradeOutput.Size = new System.Drawing.Size(0, 16);
            this.labelGradeOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.labelGradeOutput);
            this.Controls.Add(this.labelTotalOutput);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label labelTotalOutput;
        private System.Windows.Forms.Label labelGradeOutput;
    }
}

