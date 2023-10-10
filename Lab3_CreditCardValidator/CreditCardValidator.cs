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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void numKey_Leave(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSlogan_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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