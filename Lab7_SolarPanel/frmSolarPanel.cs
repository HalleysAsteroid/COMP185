namespace Lab7_SolarPanel
{
    public partial class frmSolarPanel : Form
    {
        public frmSolarPanel()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            grpCharges.Visible = false;
            numNumPanels.Value = numNumPanels.Minimum;
            numDepositAmt.Value = numDepositAmt.Minimum;
            txtFName.Clear();
            txtLName.Clear();
            txtPhoneNum.Clear();
            chkExpressInstallation.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcCharges_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" | txtLName.Text == "" | txtPhoneNum.Text == "")
            {
                MessageBox.Show("Customer information cannot be empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal numPanels = numNumPanels.Value;
                if (numPanels == 1) { numPanels++; }
                decimal panelCost = 300 * (numPanels - 2);
                grpCharges.Visible = true;
                txtAdditionalPanels.Text = panelCost.ToString("C");
                decimal totalCost = 2000 + panelCost;
                if (chkExpressInstallation.Checked)
                    totalCost = 1.05m * (2000 + panelCost);
                txtTotalCost.Text = totalCost.ToString("C");
                txtDepositAmtCharge.Text = numDepositAmt.Value.ToString("C");

                if (totalCost - numDepositAmt.Value >= 0)
                {
                    txtBalanceDue.Text = (totalCost - numDepositAmt.Value).ToString("C");
                    lblBalanceDue.Visible = true;
                    lblRefundDue.Visible = false;
                }
                else
                {
                    txtBalanceDue.Text = (-1m * (totalCost - numDepositAmt.Value)).ToString("C");
                    lblBalanceDue.Visible = false;
                    lblRefundDue.Visible = true;
                }
            }
        }
    }
}