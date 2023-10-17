namespace Lab5_TypingSchool
{
    partial class TypingSchool
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
            panel1 = new Panel();
            imgLogo = new PictureBox();
            btnPractice = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(imgLogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 150);
            panel1.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.Nimble_Fingers_Logo;
            imgLogo.Location = new Point(275, 10);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(250, 125);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // btnPractice
            // 
            btnPractice.Location = new Point(138, 205);
            btnPractice.Name = "btnPractice";
            btnPractice.Size = new Size(125, 44);
            btnPractice.TabIndex = 1;
            btnPractice.Text = "button1";
            btnPractice.UseVisualStyleBackColor = true;
            btnPractice.Visible = false;
            btnPractice.Click += btnPractice_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(510, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 3;
            // 
            // TypingSchool
            // 
            AcceptButton = btnPractice;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 877);
            Controls.Add(textBox1);
            Controls.Add(btnPractice);
            Controls.Add(panel1);
            Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "TypingSchool";
            Text = "Nimble Fingers - User Results";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox imgLogo;
        private Button btnPractice;
        private TextBox textBox1;
    }
}