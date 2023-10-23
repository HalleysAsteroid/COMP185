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
            numWPM = new NumericUpDown();
            btnStudentResults = new Button();
            lblWPM = new Label();
            lblYourResults = new Label();
            panel2 = new Panel();
            btnGrade = new Button();
            imgGrade = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWPM).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgGrade).BeginInit();
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
            btnPractice.BackColor = Color.Lime;
            btnPractice.FlatStyle = FlatStyle.Flat;
            btnPractice.ForeColor = SystemColors.ControlText;
            btnPractice.Location = new Point(313, 156);
            btnPractice.Name = "btnPractice";
            btnPractice.Size = new Size(186, 45);
            btnPractice.TabIndex = 1;
            btnPractice.Text = "Practice Now! ⏵";
            btnPractice.UseVisualStyleBackColor = false;
            btnPractice.Click += btnPractice_Click;
            // 
            // numWPM
            // 
            numWPM.BorderStyle = BorderStyle.FixedSingle;
            numWPM.Location = new Point(324, 80);
            numWPM.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numWPM.Name = "numWPM";
            numWPM.Size = new Size(120, 29);
            numWPM.TabIndex = 2;
            // 
            // btnStudentResults
            // 
            btnStudentResults.FlatStyle = FlatStyle.Flat;
            btnStudentResults.Location = new Point(256, 207);
            btnStudentResults.Name = "btnStudentResults";
            btnStudentResults.Size = new Size(300, 45);
            btnStudentResults.TabIndex = 3;
            btnStudentResults.Text = "Calculate Student Results";
            btnStudentResults.UseVisualStyleBackColor = true;
            btnStudentResults.Click += btnStudentResults_Click;
            // 
            // lblWPM
            // 
            lblWPM.AutoSize = true;
            lblWPM.Location = new Point(147, 82);
            lblWPM.Name = "lblWPM";
            lblWPM.Size = new Size(171, 23);
            lblWPM.TabIndex = 4;
            lblWPM.Text = "Words per minute:";
            // 
            // lblYourResults
            // 
            lblYourResults.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblYourResults.Location = new Point(304, 45);
            lblYourResults.Name = "lblYourResults";
            lblYourResults.Size = new Size(180, 32);
            lblYourResults.TabIndex = 5;
            lblYourResults.Text = "Your Results:";
            lblYourResults.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnGrade);
            panel2.Controls.Add(imgGrade);
            panel2.Controls.Add(lblYourResults);
            panel2.Controls.Add(numWPM);
            panel2.Controls.Add(lblWPM);
            panel2.Location = new Point(25, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(750, 625);
            panel2.TabIndex = 6;
            // 
            // btnGrade
            // 
            btnGrade.FlatStyle = FlatStyle.Flat;
            btnGrade.Location = new Point(231, 115);
            btnGrade.Name = "btnGrade";
            btnGrade.Size = new Size(300, 45);
            btnGrade.TabIndex = 7;
            btnGrade.Text = "Calculate Grade";
            btnGrade.UseVisualStyleBackColor = true;
            btnGrade.Click += btnGrade_Click;
            // 
            // imgGrade
            // 
            imgGrade.Image = Properties.Resources.A;
            imgGrade.Location = new Point(175, 179);
            imgGrade.Name = "imgGrade";
            imgGrade.Size = new Size(400, 400);
            imgGrade.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGrade.TabIndex = 6;
            imgGrade.TabStop = false;
            // 
            // TypingSchool
            // 
            AcceptButton = btnGrade;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 877);
            Controls.Add(panel2);
            Controls.Add(btnStudentResults);
            Controls.Add(btnPractice);
            Controls.Add(panel1);
            Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "TypingSchool";
            Text = "Nimble Fingers - User Results";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWPM).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgGrade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox imgLogo;
        private Button btnPractice;
        private NumericUpDown numWPM;
        private Button btnStudentResults;
        private Label lblWPM;
        private Label lblYourResults;
        private Panel panel2;
        private PictureBox imgGrade;
        private Button btnGrade;
        public int userGrade = 0;
        System.Media.SoundPlayer stamp = new System.Media.SoundPlayer(Properties.Resources.stamp);
    }
}