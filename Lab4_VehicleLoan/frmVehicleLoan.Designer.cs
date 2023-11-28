namespace Lab4_VehicleLoan
{
    partial class frmVehicleLoan
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
            grpLoanInfo = new GroupBox();
            lblNumMonths = new Label();
            lblDownPayment = new Label();
            lblVehiclePrice = new Label();
            numMonths = new NumericUpDown();
            numDownPayment = new NumericUpDown();
            numVehiclePrice = new NumericUpDown();
            groupBox1 = new GroupBox();
            radNew = new RadioButton();
            radUsed = new RadioButton();
            imgLogo = new PictureBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpDisplay = new GroupBox();
            lblAnnualInterest = new Label();
            listDisplay = new ListBox();
            grpLoanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMonths).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDownPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVehiclePrice).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            grpDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // grpLoanInfo
            // 
            grpLoanInfo.Controls.Add(lblNumMonths);
            grpLoanInfo.Controls.Add(lblDownPayment);
            grpLoanInfo.Controls.Add(lblVehiclePrice);
            grpLoanInfo.Controls.Add(numMonths);
            grpLoanInfo.Controls.Add(numDownPayment);
            grpLoanInfo.Controls.Add(numVehiclePrice);
            grpLoanInfo.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpLoanInfo.Location = new Point(52, 80);
            grpLoanInfo.Name = "grpLoanInfo";
            grpLoanInfo.Size = new Size(311, 142);
            grpLoanInfo.TabIndex = 0;
            grpLoanInfo.TabStop = false;
            grpLoanInfo.Text = "Vehicle && Loan Information";
            // 
            // lblNumMonths
            // 
            lblNumMonths.AutoSize = true;
            lblNumMonths.Location = new Point(41, 105);
            lblNumMonths.Name = "lblNumMonths";
            lblNumMonths.Size = new Size(127, 16);
            lblNumMonths.TabIndex = 5;
            lblNumMonths.Text = "Number of Months:";
            // 
            // lblDownPayment
            // 
            lblDownPayment.AutoSize = true;
            lblDownPayment.Location = new Point(11, 70);
            lblDownPayment.Name = "lblDownPayment";
            lblDownPayment.Size = new Size(158, 16);
            lblDownPayment.TabIndex = 4;
            lblDownPayment.Text = "Down Payment Amount:";
            // 
            // lblVehiclePrice
            // 
            lblVehiclePrice.AutoSize = true;
            lblVehiclePrice.Location = new Point(38, 35);
            lblVehiclePrice.Name = "lblVehiclePrice";
            lblVehiclePrice.Size = new Size(130, 16);
            lblVehiclePrice.TabIndex = 3;
            lblVehiclePrice.Text = "Price of Vehicle ($):";
            // 
            // numMonths
            // 
            numMonths.Location = new Point(174, 103);
            numMonths.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            numMonths.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMonths.Name = "numMonths";
            numMonths.Size = new Size(120, 22);
            numMonths.TabIndex = 2;
            numMonths.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numDownPayment
            // 
            numDownPayment.Location = new Point(174, 68);
            numDownPayment.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
            numDownPayment.Name = "numDownPayment";
            numDownPayment.Size = new Size(120, 22);
            numDownPayment.TabIndex = 1;
            // 
            // numVehiclePrice
            // 
            numVehiclePrice.Location = new Point(174, 33);
            numVehiclePrice.Maximum = new decimal(new int[] { 30000000, 0, 0, 0 });
            numVehiclePrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numVehiclePrice.Name = "numVehiclePrice";
            numVehiclePrice.Size = new Size(120, 22);
            numVehiclePrice.TabIndex = 0;
            numVehiclePrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(radNew);
            groupBox1.Controls.Add(radUsed);
            groupBox1.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(424, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(124, 142);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "New or Used?";
            // 
            // radNew
            // 
            radNew.AutoSize = true;
            radNew.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radNew.Location = new Point(36, 85);
            radNew.Name = "radNew";
            radNew.Size = new Size(52, 20);
            radNew.TabIndex = 1;
            radNew.Text = "New";
            radNew.UseVisualStyleBackColor = true;
            // 
            // radUsed
            // 
            radUsed.AutoSize = true;
            radUsed.Checked = true;
            radUsed.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radUsed.Location = new Point(34, 48);
            radUsed.Name = "radUsed";
            radUsed.Size = new Size(56, 20);
            radUsed.TabIndex = 0;
            radUsed.TabStop = true;
            radUsed.Text = "Used";
            radUsed.UseVisualStyleBackColor = true;
            // 
            // imgLogo
            // 
            imgLogo.Anchor = AnchorStyles.Top;
            imgLogo.Image = Properties.Resources.htLogo;
            imgLogo.Location = new Point(176, 10);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(256, 64);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 4;
            imgLogo.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Bottom;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Location = new Point(165, 647);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(263, 647);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(361, 647);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpDisplay
            // 
            grpDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDisplay.Controls.Add(lblAnnualInterest);
            grpDisplay.Controls.Add(listDisplay);
            grpDisplay.Location = new Point(52, 239);
            grpDisplay.Name = "grpDisplay";
            grpDisplay.Size = new Size(496, 402);
            grpDisplay.TabIndex = 8;
            grpDisplay.TabStop = false;
            grpDisplay.Text = "Interest && Principal Payments";
            // 
            // lblAnnualInterest
            // 
            lblAnnualInterest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAnnualInterest.AutoSize = true;
            lblAnnualInterest.Location = new Point(312, 18);
            lblAnnualInterest.Name = "lblAnnualInterest";
            lblAnnualInterest.Size = new Size(173, 16);
            lblAnnualInterest.TabIndex = 1;
            lblAnnualInterest.Text = "Annual Interest Rate: 4.5%";
            lblAnnualInterest.Visible = false;
            // 
            // listDisplay
            // 
            listDisplay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            listDisplay.Font = new Font("OCR A Extended", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listDisplay.FormattingEnabled = true;
            listDisplay.Location = new Point(11, 49);
            listDisplay.Name = "listDisplay";
            listDisplay.Size = new Size(476, 329);
            listDisplay.TabIndex = 0;
            listDisplay.Visible = false;
            // 
            // frmVehicleLoan
            // 
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = btnExit;
            ClientSize = new Size(600, 699);
            Controls.Add(grpDisplay);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(imgLogo);
            Controls.Add(groupBox1);
            Controls.Add(grpLoanInfo);
            Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmVehicleLoan";
            Text = "Vehicle Loans - Harvest & Trustee";
            Load += frmVehicleLoan_Load;
            grpLoanInfo.ResumeLayout(false);
            grpLoanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMonths).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDownPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVehiclePrice).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            grpDisplay.ResumeLayout(false);
            grpDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLoanInfo;
        private NumericUpDown numMonths;
        private NumericUpDown numDownPayment;
        private NumericUpDown numVehiclePrice;
        private GroupBox groupBox1;
        private RadioButton radNew;
        private RadioButton radUsed;
        private Label lblVehiclePrice;
        private Label lblDownPayment;
        private Label lblNumMonths;
        private PictureBox imgLogo;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private GroupBox grpDisplay;
        private ListBox listDisplay;
        private Label lblAnnualInterest;
    }
}