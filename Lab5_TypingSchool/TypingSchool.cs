namespace Lab5_TypingSchool
{
    public partial class TypingSchool : Form
    {
        public TypingSchool()
        {
            InitializeComponent();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {

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

            stamp.Play();
        }

        private void btnStudentResults_Click(object sender, EventArgs e)
        {

        }
    }
}