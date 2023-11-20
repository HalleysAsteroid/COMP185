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
            components = new System.ComponentModel.Container();
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
            imgStamp1 = new PictureBox();
            animationTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWPM).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgStamp1).BeginInit();
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
            numWPM.Location = new Point(324, 110);
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
            lblWPM.Location = new Point(147, 112);
            lblWPM.Name = "lblWPM";
            lblWPM.Size = new Size(171, 23);
            lblWPM.TabIndex = 4;
            lblWPM.Text = "Words per minute:";
            // 
            // lblYourResults
            // 
            lblYourResults.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblYourResults.Location = new Point(259, 45);
            lblYourResults.Name = "lblYourResults";
            lblYourResults.Size = new Size(240, 32);
            lblYourResults.TabIndex = 5;
            lblYourResults.Text = "Student's Results:";
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
            panel2.Controls.Add(imgStamp1);
            panel2.Location = new Point(25, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(750, 700);
            panel2.TabIndex = 6;
            // 
            // btnGrade
            // 
            btnGrade.FlatStyle = FlatStyle.Flat;
            btnGrade.Location = new Point(231, 155);
            btnGrade.Name = "btnGrade";
            btnGrade.Size = new Size(300, 45);
            btnGrade.TabIndex = 7;
            btnGrade.Text = "Calculate Grade";
            btnGrade.UseVisualStyleBackColor = true;
            btnGrade.Click += btnGrade_Click;
            // 
            // imgGrade
            // 
            imgGrade.Image = Properties.Resources.F;
            imgGrade.Location = new Point(175, 230);
            imgGrade.Name = "imgGrade";
            imgGrade.Size = new Size(400, 400);
            imgGrade.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGrade.TabIndex = 6;
            imgGrade.TabStop = false;
            // 
            // imgStamp1
            // 
            imgStamp1.BackColor = Color.Transparent;
            imgStamp1.Image = Properties.Resources.stampPNG;
            imgStamp1.Location = new Point(72, 122);
            imgStamp1.Name = "imgStamp1";
            imgStamp1.Size = new Size(600, 600);
            imgStamp1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgStamp1.TabIndex = 8;
            imgStamp1.TabStop = false;
            imgStamp1.Visible = false;
            // 
            // animationTimer
            // 
            animationTimer.Interval = 1;
            animationTimer.Tick += animationTimer_Tick;
            // 
            // TypingSchool
            // 
            AcceptButton = btnGrade;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 977);
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
            ((System.ComponentModel.ISupportInitialize)imgStamp1).EndInit();
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
        private System.Windows.Forms.Timer animationTimer;
        private PictureBox imgStamp1;
    }
}