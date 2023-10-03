using Lab3_CreditCardValidator.Properties;

namespace Lab3_CreditCardValidator
{
    public partial class CreditCardValidator : Form
    {
        public CreditCardValidator()
        {
            InitializeComponent();
            numKey.Controls[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblSlogan.Font = Resources.OCRB_Regular;
        }

    }
}