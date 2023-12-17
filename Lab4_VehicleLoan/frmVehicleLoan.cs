using Microsoft.VisualBasic;

namespace Lab4_VehicleLoan
{
    public partial class frmVehicleLoan : Form
    {

        decimal interestRate = .045M;
        double remainingPayment = 0;
        public frmVehicleLoan()
        {
            InitializeComponent();
        }

        private void frmVehicleLoan_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();

            if (numVehiclePrice.Value >= numDownPayment.Value)
            {
                remainingPayment = (double)(numVehiclePrice.Value - numDownPayment.Value);

                for (int i = 1; i <= numMonths.Value; i++)
                {
                    listDisplay.Items.Add(
                        "Month " + i.ToString("00") +
                        " | Payment: " +
                        (-1 * Financial.Pmt(
                            (double)interestRate / 12,
                            (double)numMonths.Value,
                            remainingPayment
                            )).ToString("c") +
                        " | Interest: " + 
                        (-1 * Financial.IPmt(
                            (double)interestRate / 12,
                            i,
                            (double)numMonths.Value,
                            remainingPayment)
                        ).ToString("C") +
                        " | Principal: " + 
                        (-1 * Financial.PPmt(
                            (double)interestRate / 12,
                            i,
                            (double)numMonths.Value,
                            remainingPayment
                            )).ToString("C")
                        );
                }
                listDisplay.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Entry. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listDisplay.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
            numVehiclePrice.Value = numVehiclePrice.Minimum;
            numMonths.Value = numMonths.Minimum;
            numDownPayment.Value = numDownPayment.Minimum;

        }

        private void radUsed_CheckedChanged(object sender, EventArgs e)
        {
            if (radNew.Checked)
            {
                interestRate = .029M;
            }
            else interestRate = .045M;
            lblAnnualInterest.Text = "Annual Interest Rate: " + interestRate.ToString("0.0%");
        }
    }
}