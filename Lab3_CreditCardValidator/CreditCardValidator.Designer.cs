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
            numKey = new MyNumericUpDown();
            lblSlogan = new Label();
            imgLogo = new PictureBox();
            panel1 = new Panel();
            btnValidator = new Button();
            btnRepayment = new Button();
            btnPayday = new Button();
            btnForgiveness = new Button();
            imgCard = new PictureBox();
            lblNumbers = new Label();
            lblExpiration = new Label();
            lblGoodThru = new Label();
            lblName = new Label();
            lblInstructions = new Label();
            lblFiller = new Label();
            lblValid = new Label();
            btnSubmit = new Button();
            label1 = new Label();
            cmbType = new ComboBox();
            panel2 = new Panel();
            lblCardType = new Label();
            ((System.ComponentModel.ISupportInitialize)numKey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCard).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // numKey
            // 
            numKey.Font = new Font("OCR A Extended", 22F, FontStyle.Regular, GraphicsUnit.Point);
            numKey.Location = new Point(495, 433);
            numKey.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numKey.Name = "numKey";
            numKey.Size = new Size(120, 38);
            numKey.TabIndex = 0;
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
            // 
            // btnValidator
            // 
            btnValidator.Location = new Point(0, 94);
            btnValidator.Name = "btnValidator";
            btnValidator.Size = new Size(200, 75);
            btnValidator.TabIndex = 6;
            btnValidator.Text = "Credit Card Validator";
            btnValidator.UseVisualStyleBackColor = true;
            // 
            // btnRepayment
            // 
            btnRepayment.Location = new Point(200, 94);
            btnRepayment.Name = "btnRepayment";
            btnRepayment.Size = new Size(200, 75);
            btnRepayment.TabIndex = 7;
            btnRepayment.Text = "Loan Repayment";
            btnRepayment.UseVisualStyleBackColor = true;
            // 
            // btnPayday
            // 
            btnPayday.Location = new Point(400, 94);
            btnPayday.Name = "btnPayday";
            btnPayday.Size = new Size(200, 75);
            btnPayday.TabIndex = 8;
            btnPayday.Text = "Payday Loans";
            btnPayday.UseVisualStyleBackColor = true;
            btnPayday.Click += btnPayday_Click;
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
            imgCard.Location = new Point(100, 267);
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
            lblNumbers.Location = new Point(223, 435);
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
            lblExpiration.Location = new Point(372, 531);
            lblExpiration.Name = "lblExpiration";
            lblExpiration.Size = new Size(104, 32);
            lblExpiration.TabIndex = 15;
            lblExpiration.Text = "01/26";
            // 
            // lblGoodThru
            // 
            lblGoodThru.BackColor = Color.Transparent;
            lblGoodThru.Font = new Font("OCR A Extended", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGoodThru.Location = new Point(329, 531);
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
            lblName.Location = new Point(148, 563);
            lblName.Name = "lblName";
            lblName.Size = new Size(266, 32);
            lblName.TabIndex = 14;
            lblName.Text = "Your Name Here";
            // 
            // lblInstructions
            // 
            lblInstructions.Location = new Point(100, 643);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(600, 49);
            lblInstructions.TabIndex = 18;
            lblInstructions.Text = "Please enter the last four digits of the card you would like to validate in the box on the template above.";
            lblInstructions.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFiller
            // 
            lblFiller.AutoSize = true;
            lblFiller.Location = new Point(204, 821);
            lblFiller.Margin = new Padding(3, 0, 0, 0);
            lblFiller.Name = "lblFiller";
            lblFiller.Size = new Size(324, 23);
            lblFiller.TabIndex = 19;
            lblFiller.Text = "The card number you have entered is";
            lblFiller.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValid
            // 
            lblValid.AutoSize = true;
            lblValid.BackColor = Color.Transparent;
            lblValid.Location = new Point(523, 821);
            lblValid.Margin = new Padding(0);
            lblValid.Name = "lblValid";
            lblValid.Size = new Size(73, 23);
            lblValid.TabIndex = 20;
            lblValid.Text = "invalid.";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DeepSkyBlue;
            btnSubmit.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = SystemColors.ControlText;
            btnSubmit.Location = new Point(345, 763);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 50);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Check it!";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 173);
            label1.Name = "label1";
            label1.Size = new Size(800, 91);
            label1.TabIndex = 22;
            label1.Text = "Credit Card Validator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Standard Card - 1", "Cash Back Card - 2", "Travel Card - 3", "Rewards Card - 4", "Student Account Card - 5", "Business Account Card - 6", "Store Partner Card - 7", "Employee Card - 8", "Temporary Gift Card - 9" });
            cmbType.Location = new Point(330, 12);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 31);
            cmbType.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCardType);
            panel2.Controls.Add(cmbType);
            panel2.Location = new Point(0, 700);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 55);
            panel2.TabIndex = 24;
            // 
            // lblCardType
            // 
            lblCardType.Location = new Point(220, 15);
            lblCardType.Name = "lblCardType";
            lblCardType.Size = new Size(104, 23);
            lblCardType.TabIndex = 24;
            lblCardType.Text = "Card Type:";
            lblCardType.TextAlign = ContentAlignment.TopRight;
            // 
            // CreditCardValidator
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 877);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(lblValid);
            Controls.Add(lblFiller);
            Controls.Add(lblInstructions);
            Controls.Add(lblNumbers);
            Controls.Add(lblExpiration);
            Controls.Add(lblGoodThru);
            Controls.Add(lblName);
            Controls.Add(btnForgiveness);
            Controls.Add(btnPayday);
            Controls.Add(btnRepayment);
            Controls.Add(btnValidator);
            Controls.Add(panel1);
            Controls.Add(numKey);
            Controls.Add(imgCard);
            Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "CreditCardValidator";
            Text = "Harvest & Trustee - Credit Card Validator";
            ((System.ComponentModel.ISupportInitialize)numKey).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCard).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSlogan;
        private PictureBox imgLogo;
        private Panel panel1;
        private Button btnValidator;
        private Button btnRepayment;
        private Button btnPayday;
        private Button btnForgiveness;
        private PictureBox imgCard;
        private Label lblNumbers;
        private Label lblExpiration;
        private Label lblGoodThru;
        private Label lblName;
        private Label lblInstructions;
        private MyNumericUpDown numKey;
        private Label lblFiller;
        private Label lblValid;
        private Button btnSubmit;
        private Label label1;
        private ComboBox cmbType;
        private Panel panel2;
        private Label lblCardType;
    }
}