namespace Lab3_CreditCardValidator
{
    partial class CreditCardValidator
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
            numKey = new NumericUpDown();
            lblSlogan = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numKey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numKey
            // 
            numKey.Font = new Font("OCR A Extended", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numKey.Location = new Point(336, 157);
            numKey.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numKey.Name = "numKey";
            numKey.Size = new Size(120, 27);
            numKey.TabIndex = 0;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Location = new Point(294, 97);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(206, 23);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "With you all the way.™";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.htLogo;
            pictureBox1.Location = new Point(264, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(541, 229);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // CreditCardValidator
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 877);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblSlogan);
            Controls.Add(numKey);
            Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "CreditCardValidator";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numKey).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numKey;
        private Label lblSlogan;
        private PictureBox pictureBox1;
        private Label label1;
    }
}