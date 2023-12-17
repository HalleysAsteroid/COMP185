namespace Lab7_SolarPanel
{
    partial class frmSolarPanel
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
            grpCustomerInfo = new GroupBox();
            lblPhoneNum = new Label();
            lblLName = new Label();
            lblFName = new Label();
            txtPhoneNum = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            grpInstallationOptions = new GroupBox();
            chkExpressInstallation = new CheckBox();
            numDepositAmt = new NumericUpDown();
            lblDepositAmt = new Label();
            lblNumPanels = new Label();
            numNumPanels = new NumericUpDown();
            grpCharges = new GroupBox();
            lblRefundDue = new Label();
            lblBalanceDue = new Label();
            lblDepositAmtCharge = new Label();
            lblTotalCost = new Label();
            lblAdditionalPanels = new Label();
            lblBaseCharge = new Label();
            txtBalanceDue = new TextBox();
            txtDepositAmtCharge = new TextBox();
            txtTotalCost = new TextBox();
            txtAdditionalPanels = new TextBox();
            txtBaseCharge = new TextBox();
            btnClear = new Button();
            btnClose = new Button();
            btnCalcCharges = new Button();
            button4 = new Button();
            lblTitle = new Label();
            grpCustomerInfo.SuspendLayout();
            grpInstallationOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDepositAmt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumPanels).BeginInit();
            grpCharges.SuspendLayout();
            SuspendLayout();
            // 
            // grpCustomerInfo
            // 
            grpCustomerInfo.Controls.Add(lblPhoneNum);
            grpCustomerInfo.Controls.Add(lblLName);
            grpCustomerInfo.Controls.Add(lblFName);
            grpCustomerInfo.Controls.Add(txtPhoneNum);
            grpCustomerInfo.Controls.Add(txtLName);
            grpCustomerInfo.Controls.Add(txtFName);
            grpCustomerInfo.Location = new Point(25, 43);
            grpCustomerInfo.Margin = new Padding(5);
            grpCustomerInfo.Name = "grpCustomerInfo";
            grpCustomerInfo.Padding = new Padding(5);
            grpCustomerInfo.Size = new Size(550, 117);
            grpCustomerInfo.TabIndex = 0;
            grpCustomerInfo.TabStop = false;
            grpCustomerInfo.Text = "Customer Information";
            // 
            // lblPhoneNum
            // 
            lblPhoneNum.AutoSize = true;
            lblPhoneNum.Location = new Point(304, 40);
            lblPhoneNum.Name = "lblPhoneNum";
            lblPhoneNum.Size = new Size(69, 23);
            lblPhoneNum.TabIndex = 5;
            lblPhoneNum.Text = "Phone:";
            lblPhoneNum.Click += lblPhone_Click;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(25, 76);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(108, 23);
            lblLName.TabIndex = 4;
            lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(21, 40);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(112, 23);
            lblFName.TabIndex = 3;
            lblFName.Text = "First Name:";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(379, 37);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(150, 29);
            txtPhoneNum.TabIndex = 2;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(135, 73);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(150, 29);
            txtLName.TabIndex = 1;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(135, 37);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(150, 29);
            txtFName.TabIndex = 0;
            // 
            // grpInstallationOptions
            // 
            grpInstallationOptions.Controls.Add(chkExpressInstallation);
            grpInstallationOptions.Controls.Add(numDepositAmt);
            grpInstallationOptions.Controls.Add(lblDepositAmt);
            grpInstallationOptions.Controls.Add(lblNumPanels);
            grpInstallationOptions.Controls.Add(numNumPanels);
            grpInstallationOptions.Location = new Point(25, 193);
            grpInstallationOptions.Margin = new Padding(5);
            grpInstallationOptions.Name = "grpInstallationOptions";
            grpInstallationOptions.Padding = new Padding(5);
            grpInstallationOptions.Size = new Size(350, 150);
            grpInstallationOptions.TabIndex = 1;
            grpInstallationOptions.TabStop = false;
            grpInstallationOptions.Text = "Installation Options";
            // 
            // chkExpressInstallation
            // 
            chkExpressInstallation.AutoSize = true;
            chkExpressInstallation.Location = new Point(55, 112);
            chkExpressInstallation.Name = "chkExpressInstallation";
            chkExpressInstallation.Size = new Size(242, 27);
            chkExpressInstallation.TabIndex = 8;
            chkExpressInstallation.Text = "Express Installation (5%)";
            chkExpressInstallation.UseVisualStyleBackColor = true;
            // 
            // numDepositAmt
            // 
            numDepositAmt.Location = new Point(187, 77);
            numDepositAmt.Maximum = new decimal(new int[] { 316470, 0, 0, 0 });
            numDepositAmt.Name = "numDepositAmt";
            numDepositAmt.Size = new Size(150, 29);
            numDepositAmt.TabIndex = 7;
            // 
            // lblDepositAmt
            // 
            lblDepositAmt.AutoSize = true;
            lblDepositAmt.Location = new Point(26, 79);
            lblDepositAmt.Name = "lblDepositAmt";
            lblDepositAmt.Size = new Size(155, 23);
            lblDepositAmt.TabIndex = 5;
            lblDepositAmt.Text = "Deposit Amount:";
            // 
            // lblNumPanels
            // 
            lblNumPanels.AutoSize = true;
            lblNumPanels.Location = new Point(13, 42);
            lblNumPanels.Name = "lblNumPanels";
            lblNumPanels.Size = new Size(168, 23);
            lblNumPanels.TabIndex = 4;
            lblNumPanels.Text = "Number of Panels:";
            // 
            // numNumPanels
            // 
            numNumPanels.Location = new Point(187, 40);
            numNumPanels.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNumPanels.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNumPanels.Name = "numNumPanels";
            numNumPanels.Size = new Size(150, 29);
            numNumPanels.TabIndex = 6;
            numNumPanels.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpCharges
            // 
            grpCharges.Controls.Add(lblRefundDue);
            grpCharges.Controls.Add(lblBalanceDue);
            grpCharges.Controls.Add(lblDepositAmtCharge);
            grpCharges.Controls.Add(lblTotalCost);
            grpCharges.Controls.Add(lblAdditionalPanels);
            grpCharges.Controls.Add(lblBaseCharge);
            grpCharges.Controls.Add(txtBalanceDue);
            grpCharges.Controls.Add(txtDepositAmtCharge);
            grpCharges.Controls.Add(txtTotalCost);
            grpCharges.Controls.Add(txtAdditionalPanels);
            grpCharges.Controls.Add(txtBaseCharge);
            grpCharges.Controls.Add(btnClear);
            grpCharges.Controls.Add(btnClose);
            grpCharges.Location = new Point(25, 368);
            grpCharges.Margin = new Padding(5);
            grpCharges.Name = "grpCharges";
            grpCharges.Padding = new Padding(5);
            grpCharges.Size = new Size(550, 200);
            grpCharges.TabIndex = 2;
            grpCharges.TabStop = false;
            grpCharges.Text = "Charges";
            grpCharges.Visible = false;
            // 
            // lblRefundDue
            // 
            lblRefundDue.Anchor = AnchorStyles.Right;
            lblRefundDue.AutoSize = true;
            lblRefundDue.Location = new Point(101, 156);
            lblRefundDue.Name = "lblRefundDue";
            lblRefundDue.Size = new Size(116, 23);
            lblRefundDue.TabIndex = 17;
            lblRefundDue.Text = "Refund Due:";
            // 
            // lblBalanceDue
            // 
            lblBalanceDue.Anchor = AnchorStyles.Right;
            lblBalanceDue.AutoSize = true;
            lblBalanceDue.Location = new Point(96, 156);
            lblBalanceDue.Name = "lblBalanceDue";
            lblBalanceDue.Size = new Size(121, 23);
            lblBalanceDue.TabIndex = 16;
            lblBalanceDue.Text = "Balance Due:";
            // 
            // lblDepositAmtCharge
            // 
            lblDepositAmtCharge.AutoSize = true;
            lblDepositAmtCharge.Location = new Point(62, 124);
            lblDepositAmtCharge.Name = "lblDepositAmtCharge";
            lblDepositAmtCharge.Size = new Size(155, 23);
            lblDepositAmtCharge.TabIndex = 15;
            lblDepositAmtCharge.Text = "Deposit Amount:";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(115, 92);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(102, 23);
            lblTotalCost.TabIndex = 14;
            lblTotalCost.Text = "Total Cost:";
            // 
            // lblAdditionalPanels
            // 
            lblAdditionalPanels.AutoSize = true;
            lblAdditionalPanels.Location = new Point(51, 60);
            lblAdditionalPanels.Name = "lblAdditionalPanels";
            lblAdditionalPanels.Size = new Size(166, 23);
            lblAdditionalPanels.TabIndex = 13;
            lblAdditionalPanels.Text = "Additional Panels:";
            // 
            // lblBaseCharge
            // 
            lblBaseCharge.AutoSize = true;
            lblBaseCharge.Location = new Point(7, 28);
            lblBaseCharge.Name = "lblBaseCharge";
            lblBaseCharge.Size = new Size(210, 23);
            lblBaseCharge.TabIndex = 12;
            lblBaseCharge.Text = "Base Charge (2 Panels):";
            // 
            // txtBalanceDue
            // 
            txtBalanceDue.Location = new Point(223, 153);
            txtBalanceDue.Name = "txtBalanceDue";
            txtBalanceDue.ReadOnly = true;
            txtBalanceDue.Size = new Size(125, 29);
            txtBalanceDue.TabIndex = 11;
            // 
            // txtDepositAmtCharge
            // 
            txtDepositAmtCharge.Location = new Point(223, 121);
            txtDepositAmtCharge.Name = "txtDepositAmtCharge";
            txtDepositAmtCharge.ReadOnly = true;
            txtDepositAmtCharge.Size = new Size(125, 29);
            txtDepositAmtCharge.TabIndex = 10;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(223, 89);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(125, 29);
            txtTotalCost.TabIndex = 9;
            // 
            // txtAdditionalPanels
            // 
            txtAdditionalPanels.Location = new Point(223, 57);
            txtAdditionalPanels.Name = "txtAdditionalPanels";
            txtAdditionalPanels.ReadOnly = true;
            txtAdditionalPanels.Size = new Size(125, 29);
            txtAdditionalPanels.TabIndex = 8;
            // 
            // txtBaseCharge
            // 
            txtBaseCharge.Location = new Point(223, 25);
            txtBaseCharge.Name = "txtBaseCharge";
            txtBaseCharge.ReadOnly = true;
            txtBaseCharge.Size = new Size(125, 29);
            txtBaseCharge.TabIndex = 7;
            txtBaseCharge.Text = "$2,000.00";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(380, 54);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 35);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(380, 121);
            btnClose.Margin = new Padding(5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 35);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCalcCharges
            // 
            btnCalcCharges.Location = new Point(429, 238);
            btnCalcCharges.Margin = new Padding(5);
            btnCalcCharges.Name = "btnCalcCharges";
            btnCalcCharges.Size = new Size(125, 60);
            btnCalcCharges.TabIndex = 3;
            btnCalcCharges.Text = "Calculate Charges";
            btnCalcCharges.UseVisualStyleBackColor = true;
            btnCalcCharges.Click += btnCalcCharges_Click;
            // 
            // button4
            // 
            button4.Location = new Point(608, 500);
            button4.Name = "button4";
            button4.Size = new Size(9, 9);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(192, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 23);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Megawatt Solar Panels, Inc.";
            // 
            // frmSolarPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(600, 577);
            Controls.Add(lblTitle);
            Controls.Add(button4);
            Controls.Add(btnCalcCharges);
            Controls.Add(grpCharges);
            Controls.Add(grpInstallationOptions);
            Controls.Add(grpCustomerInfo);
            Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "frmSolarPanel";
            Text = "Installation Fees - Megawatt Solar Panels, Inc.";
            grpCustomerInfo.ResumeLayout(false);
            grpCustomerInfo.PerformLayout();
            grpInstallationOptions.ResumeLayout(false);
            grpInstallationOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDepositAmt).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumPanels).EndInit();
            grpCharges.ResumeLayout(false);
            grpCharges.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpCustomerInfo;
        private GroupBox grpInstallationOptions;
        private GroupBox grpCharges;
        private Button btnCalcCharges;
        private Button button4;
        private Button btnClear;
        private Button btnClose;
        private Label lblPhoneNum;
        private Label lblLName;
        private Label lblFName;
        private TextBox txtPhoneNum;
        private TextBox txtLName;
        private TextBox txtFName;
        private Label lblDepositAmt;
        private Label lblNumPanels;
        private Label lblBalanceDue;
        private Label lblDepositAmtCharge;
        private Label lblTotalCost;
        private Label lblAdditionalPanels;
        private Label lblBaseCharge;
        private TextBox txtBalanceDue;
        private TextBox txtDepositAmtCharge;
        private TextBox txtTotalCost;
        private TextBox txtAdditionalPanels;
        private TextBox txtBaseCharge;
        private Label lblTitle;
        private NumericUpDown numNumPanels;
        private CheckBox chkExpressInstallation;
        private NumericUpDown numDepositAmt;
        private Label lblRefundDue;
    }
}