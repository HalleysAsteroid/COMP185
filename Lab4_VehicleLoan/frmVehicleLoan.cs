using Microsoft.VisualBasic;
using System.Xml.Serialization;

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

            if (numVehiclePrice.Value >= numDownPayment.Value)
            {
                remainingPayment = (double)(numVehiclePrice.Value - numDownPayment.Value);
                if (radNew.Checked)
                {
                    interestRate = .029M;
                }
                else interestRate = .045M;


                interestRate = .089M;
                for (int i = 1; i <= numMonths.Value; i++)
                {
                    listDisplay.Items.Add(
                        "Month " + i.ToString("00") +
                        " | Payment: " +
                        Financial.Pmt(
                            (double)interestRate / 12,
                            (double)numMonths.Value,
                            (double)remainingPayment
                            ).ToString("C") +
                        " | Interest: " + -1*Financial.IPmt(
                            (double)interestRate / 12,
                            i,
                            (double)numMonths.Value,
                            remainingPayment) +
                        " | Principal: " + -1*Financial.PPmt(
                            (double)interestRate / 12,
                            i,
                            (double)numMonths.Value,
                            (double)remainingPayment
                            )
                        );
                }
                listDisplay.Visible = true;
            }
            else listDisplay.Visible = false;
        }
    }
}