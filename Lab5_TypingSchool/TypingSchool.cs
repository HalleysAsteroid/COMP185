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
            //panel2.Controls.Add(imgStamp);
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            var practiceForm = new TypingPractice(this);
            practiceForm.ShowDialog();
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
            imgStamp1.Location = new Point(272, -128);
            imgStamp1.Visible = true;

            stamp.Play();
        }

        public void changeWPM(double wpm)
        {
            numWPM.Value = (decimal)wpm;
        }

        private void btnStudentResults_Click(object sender, EventArgs e)
        {

        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            lblYourResults.Text = iterator.ToString();

            imgStamp1.Location = new Point(imgStamp1.Location.X - 8, imgStamp1.Location.Y + 8);


            if (iterator == 25)
            {
                animationTimer.Stop();
                imgStamp1.Visible = false;
                iterator = 0;
            }
            else
            {
                iterator++;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(stampimage, new Point(0, 0));
        }

        private void imgStamp1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(stampimage, new Point(0, 0));
        }
    }
}