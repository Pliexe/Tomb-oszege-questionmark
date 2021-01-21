
namespace Tomb_oszege_questionmark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bevitelBtn = new System.Windows.Forms.Button();
            this.numericUpDownElemenSzam = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElemenSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // bevitelBtn
            // 
            this.bevitelBtn.Location = new System.Drawing.Point(370, 138);
            this.bevitelBtn.Name = "bevitelBtn";
            this.bevitelBtn.Size = new System.Drawing.Size(75, 23);
            this.bevitelBtn.TabIndex = 0;
            this.bevitelBtn.Text = "Bevitel";
            this.bevitelBtn.UseVisualStyleBackColor = true;
            this.bevitelBtn.Click += new System.EventHandler(this.bevitelBtn_Click);
            // 
            // numericUpDownElemenSzam
            // 
            this.numericUpDownElemenSzam.Location = new System.Drawing.Point(232, 138);
            this.numericUpDownElemenSzam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownElemenSzam.Name = "numericUpDownElemenSzam";
            this.numericUpDownElemenSzam.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownElemenSzam.TabIndex = 1;
            this.numericUpDownElemenSzam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(232, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 345);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nullázás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDownElemenSzam);
            this.Controls.Add(this.bevitelBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElemenSzam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bevitelBtn;
        private System.Windows.Forms.NumericUpDown numericUpDownElemenSzam;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

