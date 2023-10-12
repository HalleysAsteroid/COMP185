using Lab3_CreditCardValidator.Properties;

namespace Lab3_CreditCardValidator
{
    public partial class CreditCardValidator : Form
    {
        public CreditCardValidator()
        {
            InitializeComponent();
            numKey.Controls[0].Visible = false;
            imgCard.Controls.Add(lblName);
            lblName.Location = new Point(48, 296);
            imgCard.Controls.Add(lblNumbers);
            lblNumbers.Location = new Point(123, 168);
            imgCard.Controls.Add(lblGoodThru);
            lblGoodThru.Location = new Point(229, 264);
            imgCard.Controls.Add(lblExpiration);
            lblExpiration.Location = new Point(272, 264);
            imgCard.Controls.Add(numKey);
            numKey.Location = new Point(395, 166);
            cmbType.SelectedIndex = 0;
        }

        public class MyNumericUpDown : NumericUpDown
        {
            protected override void UpdateEditText()
            {
                this.Text = this.Value.ToString().PadLeft(4, '0');
            }
        }

        public void calculateValidity(int digits, int divisor)
        {
            String s = digits.ToString().PadLeft(4, '0');
            int x = int.Parse(s.Substring(0, 3));
            int y = int.Parse(s.Substring(3, 1));
            if (isValidCard(x, y, divisor))
            {
                lblValid.ForeColor = Color.Green;
                lblValid.Text = "valid!";
            }
            else
            {
                lblValid.ForeColor = Color.Red;
                lblValid.Text = "invalid.";
            }
        }

        public bool isValidCard(int leading, int quotient, int checkDigit)
        {
            if (leading % checkDigit == quotient)
            {
                return true;
            }
            else return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int checkDigit = 1 + cmbType.SelectedIndex;
            calculateValidity((int)numKey.Value, checkDigit);
        }

        private void btnPayday_Click(object sender, EventArgs e)
        {
            MessageBox.Show
    (
    "Unfortunately, due to a string of robberies in our Washington D.C. branches, we are unable to offer Payday Loans at this time. We thank you for your patronage and your continued patience.",
    "Page Not Available",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning
    );
        }

        private void btnForgiveness_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                "Sorry, the page you were looking for does not exist. \n \n Please try instead: \n Loan Repayment",
                "Page Not Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
    }
}