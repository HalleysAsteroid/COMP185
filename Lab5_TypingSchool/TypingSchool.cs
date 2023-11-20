using Lab5_TypingSchool.Properties;

namespace Lab5_TypingSchool
{
    public partial class TypingSchool : Form
    {
        int iterator = 0;
        private Image stampimage = Resources.stampPNG;


        public TypingSchool()
        {
            InitializeComponent();
            imgStamp1.BringToFront();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            lblYourResults.Text = "Your Results";
            numWPM.Value = 0;
            var practiceForm = new TypingPractice(this);
            btnGrade.Enabled = false;
            practiceForm.ShowDialog();
            btnGrade_Click(sender, e);
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            int[] minScores = { 76, 51, 31, 16, 0 };

            for (int i = 0; i < 5; i++)
            {
                if (numWPM.Value >= minScores[i])
                {
                    userGrade = i;
                    break;
                }
                else userGrade = 4;
            }

            switch (userGrade)
            {
                case 0:
                    imgGrade.Image = Properties.Resources.A;
                    break;
                case 1:
                    imgGrade.Image = Properties.Resources.B;
                    break;
                case 2:
                    imgGrade.Image = Properties.Resources.C;
                    break;
                case 3:
                    imgGrade.Image = Properties.Resources.D;
                    break;
                case 4:
                    imgGrade.Image = Properties.Resources.F;
                    break;
                default:
                    break;
            }

            animationTimer.Start();
            imgStamp1.Location = new Point(272, -78);
            imgStamp1.Visible = true;
            //Temporarily sets background image of form to a screenshot of the form to fake transparency; This was the least terrible looking way I could find to do this but is still bad :)
            panel2.BackgroundImage = Resources.typingSchoolBG;

            btnPractice.Enabled = false;

            //Comment out below line to disable sound effect
            stamp.Play();
        }

        public void changeWPM(double wpm)
        {
            numWPM.Value = (decimal)wpm;
        }

        private void btnStudentResults_Click(object sender, EventArgs e)
        {
            lblYourResults.Text = "Student's Results";
            btnGrade.Enabled = true;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {

            imgStamp1.Location = new Point(imgStamp1.Location.X - 8, imgStamp1.Location.Y + 8);

            if (iterator == 25)
            {
                animationTimer.Stop();
                imgStamp1.Visible = false;
                panel2.BackgroundImage = null;
                iterator = 0;

                btnPractice.Enabled = true;
            }
            else
            {
                iterator++;
            }
        }
    }
}