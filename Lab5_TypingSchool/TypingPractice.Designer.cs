namespace Lab5_TypingSchool
{
    partial class TypingPractice
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            imgLogo = new PictureBox();
            txtExample = new RichTextBox();
            txtAnswer = new RichTextBox();
            timer = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnStart = new Button();
            label1 = new Label();
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
            panel1.TabIndex = 1;
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
            // txtExample
            // 
            txtExample.Location = new Point(50, 175);
            txtExample.Name = "txtExample";
            txtExample.ReadOnly = true;
            txtExample.Size = new Size(700, 250);
            txtExample.TabIndex = 2;
            txtExample.Text = "";
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = SystemColors.ControlLightLight;
            txtAnswer.Location = new Point(50, 450);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.Size = new Size(700, 250);
            txtAnswer.TabIndex = 3;
            txtAnswer.Text = "";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblTimer
            // 
            lblTimer.Location = new Point(307, 710);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(186, 45);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.Visible = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Lime;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = SystemColors.ControlText;
            btnStart.Location = new Point(307, 710);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(186, 45);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start! ⏵";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 803);
            label1.Name = "label1";
            label1.Size = new Size(726, 23);
            label1.TabIndex = 6;
            label1.Text = "Practice will complete automatically when your input matches the text shown above.";
            // 
            // TypingPractice
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 877);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(lblTimer);
            Controls.Add(txtAnswer);
            Controls.Add(txtExample);
            Controls.Add(panel1);
            Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "TypingPractice";
            Text = "Nimble Fingers - Practice";
            Load += TypingPractice_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox imgLogo;
        private RichTextBox txtExample;
        private RichTextBox txtAnswer;
        private System.Windows.Forms.Timer timer;
        private Label lblTimer;
        private Button btnStart;
        private Label label1;
    }
}