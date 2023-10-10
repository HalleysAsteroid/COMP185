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
            imgLogo = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnForgiveness = new Button();
            imgCard = new PictureBox();
            lblNumbers = new Label();
            lblExpiration = new Label();
            lblGoodThru = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)numKey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCard).BeginInit();
            SuspendLayout();
            // 
            // numKey
            // 
            numKey.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            numKey.Location = new Point(395, 341);
            numKey.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numKey.Name = "numKey";
            numKey.Size = new Size(120, 38);
            numKey.TabIndex = 0;
            numKey.Leave += numKey_Leave;
            // 
            // lblSlogan
            // 
            lblSlogan.BackColor = Color.Transparent;
            lblSlogan.Location = new Point(272, 68);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(256, 23);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "With you all the way.™";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            lblSlogan.Click += lblSlogan_Click;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.htLogo;
            imgLogo.Location = new Point(272, 3);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(256, 64);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 2;
            imgLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(imgLogo);
            panel1.Controls.Add(lblSlogan);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 93);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(0, 94);
            button1.Name = "button1";
            button1.Size = new Size(200, 75);
            button1.TabIndex = 6;
            button1.Text = "Credit Card Validator";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(200, 94);
            button2.Name = "button2";
            button2.Size = new Size(200, 75);
            button2.TabIndex = 7;
            button2.Text = "Loan Repayment";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(400, 94);
            button3.Name = "button3";
            button3.Size = new Size(200, 75);
            button3.TabIndex = 8;
            button3.Text = "Payday Loans";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnForgiveness
            // 
            btnForgiveness.Location = new Point(600, 94);
            btnForgiveness.Name = "btnForgiveness";
            btnForgiveness.Size = new Size(200, 75);
            btnForgiveness.TabIndex = 9;
            btnForgiveness.Text = "Loan Forgiveness Program";
            btnForgiveness.UseVisualStyleBackColor = true;
            btnForgiveness.Click += btnForgiveness_Click;
            // 
            // imgCard
            // 
            imgCard.Image = Properties.Resources.creditCardTemplate;
            imgCard.Location = new Point(0, 175);
            imgCard.Name = "imgCard";
            imgCard.Size = new Size(600, 368);
            imgCard.SizeMode = PictureBoxSizeMode.Zoom;
            imgCard.TabIndex = 10;
            imgCard.TabStop = false;
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.BackColor = Color.Transparent;
            lblNumbers.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumbers.Location = new Point(123, 343);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(266, 32);
            lblNumbers.TabIndex = 17;
            lblNumbers.Text = "1234 5678 9012";
            // 
            // lblExpiration
            // 
            lblExpiration.AutoSize = true;
            lblExpiration.BackColor = Color.Transparent;
            lblExpiration.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpiration.Location = new Point(272, 439);
            lblExpiration.Name = "lblExpiration";
            lblExpiration.Size = new Size(104, 32);
            lblExpiration.TabIndex = 15;
            lblExpiration.Text = "01/26";
            // 
            // lblGoodThru
            // 
            lblGoodThru.BackColor = Color.Transparent;
            lblGoodThru.Font = new Font("OCR A Extended", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGoodThru.Location = new Point(229, 439);
            lblGoodThru.Name = "lblGoodThru";
            lblGoodThru.Size = new Size(43, 32);
            lblGoodThru.TabIndex = 16;
            lblGoodThru.Text = "GoodThru";
            lblGoodThru.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(48, 471);
            lblName.Name = "lblName";
            lblName.Size = new Size(266, 32);
            lblName.TabIndex = 14;
            lblName.Text = "Your Name Here";
            // 
            // CreditCardValidator
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 877);
            Controls.Add(lblNumbers);
            Controls.Add(lblExpiration);
            Controls.Add(lblGoodThru);
            Controls.Add(lblName);
            Controls.Add(btnForgiveness);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(numKey);
            Controls.Add(imgCard);
            Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "CreditCardValidator";
            Text = "Harvest & Trustee - Credit Card Validator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numKey).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numKey;
        private Label lblSlogan;
        private PictureBox imgLogo;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnForgiveness;
        private PictureBox imgCard;
        private Label lblNumbers;
        private Label lblExpiration;
        private Label lblGoodThru;
        private Label lblName;
    }
}