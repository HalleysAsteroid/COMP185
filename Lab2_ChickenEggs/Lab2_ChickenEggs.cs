namespace Lab2_ChickenEggs
{
    public partial class Lab2_ChickenEggs : Form
    {
        public Lab2_ChickenEggs()
        {
            InitializeComponent();
            imgWood.Controls.Add(lblTitle);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private double calculateSum(double a, double b, double c, double d)
        {
            return (a + b + c + d);
        }

        private double calculateAvg(double a, double b, double c, double d)
        {
            return calculateSum(a, b, c, d) / 4.0;
        }

        private void onLeaveFocus()
        {
            if (numChicken1.Value < 0 || numChicken2.Value < 0 || numChicken3.Value < 0 || numChicken4.Value < 0)
            {
                imgRancher.Image = Properties.Resources.rancherAngry;
                lblFlavor.Text = "Hey! Whaddaya mean yer chicken's producin' negative eggs?! Either ye've got a rogue chicken or ye need ta quit futzin' around and get back ta work!";
                lblAverage.Visible = false;
                lblSum.Visible = false;
            }
            else if (numChicken1.Value == 0 && numChicken2.Value == 0 && numChicken3.Value == 0 && numChicken4.Value == 0)
            {
                imgRancher.Image = Properties.Resources.rancherSad;
                double sum = calculateSum((double)numChicken1.Value, (double)numChicken2.Value, (double)numChicken3.Value, (double)numChicken4.Value);
                double avg = calculateAvg((double)numChicken1.Value, (double)numChicken2.Value, (double)numChicken3.Value, (double)numChicken4.Value);
                lblFlavor.Text = "Agh, sorry lad. A bad season happens to everyone. Don't let it get to ye too much.";
                lblSum.Text = "Yer chickens produced a total of " + sum + " eggs today.";
                lblAverage.Text = "Yer chickens are producin' an average of " + avg + " eggs per day.";
                lblAverage.Visible = true;
                lblSum.Visible = true;
            }
            else
            {
                imgRancher.Image = Properties.Resources.rancherHappy;
                double sum = calculateSum((double)numChicken1.Value, (double)numChicken2.Value, (double)numChicken3.Value, (double)numChicken4.Value);
                double avg = calculateAvg((double)numChicken1.Value, (double)numChicken2.Value, (double)numChicken3.Value, (double)numChicken4.Value);
                lblFlavor.Text = "Looks like ye got a good haul for today! Let's see here...";
                lblSum.Text = "Yer chickens produced a total of " + sum + " eggs today.";
                lblAverage.Text = "Yer chickens are producin' an average of " + avg + " eggs per day.";
                lblAverage.Visible = true;
                lblSum.Visible = true;
            }
        }

        private void numChicken1_Leave(object sender, EventArgs e)
        {
            onLeaveFocus();
        }

        private void numChicken2_Leave(object sender, EventArgs e)
        {
            onLeaveFocus();
        }
        private void numChicken3_Leave(object sender, EventArgs e)
        {
            onLeaveFocus();
        }

        private void numChicken4_Leave(object sender, EventArgs e)
        {
            onLeaveFocus();
        }

    }
}