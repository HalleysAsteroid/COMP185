namespace Lab5_TypingSchool
{
    public partial class TypingPractice : Form
    {
        //Change practiceSeconds value here to increase time for testing purposes
        double practiceSeconds = 0;
        double score = 0;
        TypingSchool parentForm;

        String[] exampleText = new String[]
            {
                "The blowfish puffs himself up four, five times larger than normal and why? Why does he do that? So that it makes him intimidating, that's why. Intimidating! So that the other, scarier fish are scared off. And that's you! You are a blowfish. You see it's just all an illusion. You see it's... it's nothing but air. Now... who messes with the blowfish, Jesse? You're damn right. You are a blowfish. Say it again. Say it like you mean it. You're a BLOWFISH!",
                "Yes, I do, I have... concerns. If we're going to go down this road and clearly, we are, for the sake of my brother-in-law. At any rate, I need some assurances that we're going to go about this in a manner that is extremely safe and cautious. You know, I'm a bookkeeper so I know what money laundering is. And uh... as with most things, the devil is in the details. So, to begin with, what are we saying is the source of this money?",
                "I know this is the final release, but can we add more features? Concept is bang on, but can we look at a better execution? There is too much white space. Can you make the logo bigger? Yes, bigger. Bigger still. The logo is too big. Are you busy this weekend? I have a new project with a tight deadline. Thanks for taking the time to make the website, but I already made it in Wix. Could you move the text a tad to the left? Can you please jazz it up a little, make it stand out more, make it pop? Make it feel... original. Can you make it look like this clipart I found? Could you do an actual logo instead of a font? That's not what I saw in my head at all! Yes, I got your invoice... it seems really high, why did you charge so much?"
            };

        double[] exampleWords = new double[]
        {
                60,
                66,
                116
        };

        int index;

        public TypingPractice()
        {
            InitializeComponent();
        }

        public TypingPractice(TypingSchool inputForm):this()
        {
            parentForm = inputForm;
        }

        private void TypingPractice_Load(object sender, EventArgs e)
        {


            Random rnd = new Random();
            index = rnd.Next(exampleText.Length);

            txtExample.Text = exampleText[index];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnStart.Visible = false;
            lblTimer.Visible = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Iterate Timer
            practiceSeconds++;

            //Update timer text
            var timespan = TimeSpan.FromSeconds(practiceSeconds);
            lblTimer.Text = timespan.ToString(@"mm\:ss");

            //Check if text is valid
            if (txtExample.Text == txtAnswer.Text)
            {
                timer.Stop();
                score = exampleWords[index] / (practiceSeconds / 60.0);
                System.Windows.Forms.Panel panel = (System.Windows.Forms.Panel)parentForm.Controls["panel2"];
                System.Windows.Forms.NumericUpDown changeValue = (System.Windows.Forms.NumericUpDown)panel.Controls["numWPM"];
                changeValue.Value = (decimal)score;
                this.Close();
            }
        }
    }
}
