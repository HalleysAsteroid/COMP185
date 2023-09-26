namespace Lab1_ClickableFlags
{
    public partial class Lab1_ClickableFlags : Form
    {
        public Lab1_ClickableFlags()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgEstonia_Click(object sender, EventArgs e)
        {
            lblFlagInfo.Text = "Estonia";
        }

        private void imgLatvia_Click(object sender, EventArgs e)
        {
            lblFlagInfo.Text = "Latvia";
        }

        private void imgPoland_Click(object sender, EventArgs e)
        {
            lblFlagInfo.Text = "Poland";
        }

        private void Lab1_ClickableFlags_Load(object sender, EventArgs e)
        {

        }
    }
}