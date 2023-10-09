namespace Lab2_ChickenEggs
{
    partial class Lab2_ChickenEggs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numChicken1 = new NumericUpDown();
            numChicken2 = new NumericUpDown();
            numChicken4 = new NumericUpDown();
            numChicken3 = new NumericUpDown();
            lblSum = new Label();
            lblAverage = new Label();
            grpResults = new GroupBox();
            lblFlavor = new Label();
            imgRancher = new PictureBox();
            imgChicken1 = new PictureBox();
            imgChicken2 = new PictureBox();
            imgChicken3 = new PictureBox();
            imgChicken4 = new PictureBox();
            imgWood = new PictureBox();
            lblTitle = new Label();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)numChicken1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChicken2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChicken4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChicken3).BeginInit();
            grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgRancher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgWood).BeginInit();
            SuspendLayout();
            // 
            // numChicken1
            // 
            numChicken1.Location = new Point(200, 346);
            numChicken1.Margin = new Padding(5);
            numChicken1.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numChicken1.Name = "numChicken1";
            numChicken1.Size = new Size(150, 29);
            numChicken1.TabIndex = 0;
            numChicken1.Leave += numChicken1_Leave;
            // 
            // numChicken2
            // 
            numChicken2.Location = new Point(450, 346);
            numChicken2.Margin = new Padding(5);
            numChicken2.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numChicken2.Name = "numChicken2";
            numChicken2.Size = new Size(150, 29);
            numChicken2.TabIndex = 1;
            numChicken2.Leave += numChicken2_Leave;
            // 
            // numChicken4
            // 
            numChicken4.Location = new Point(450, 637);
            numChicken4.Margin = new Padding(5);
            numChicken4.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numChicken4.Name = "numChicken4";
            numChicken4.Size = new Size(150, 29);
            numChicken4.TabIndex = 2;
            numChicken4.Leave += numChicken4_Leave;
            // 
            // numChicken3
            // 
            numChicken3.Location = new Point(200, 637);
            numChicken3.Margin = new Padding(5);
            numChicken3.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numChicken3.Name = "numChicken3";
            numChicken3.Size = new Size(150, 29);
            numChicken3.TabIndex = 3;
            numChicken3.Leave += numChicken3_Leave;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(208, 108);
            lblSum.Margin = new Padding(5, 0, 5, 0);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(49, 23);
            lblSum.TabIndex = 4;
            lblSum.Text = "Sum";
            lblSum.Visible = false;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(208, 145);
            lblAverage.Margin = new Padding(5, 0, 5, 0);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(42, 23);
            lblAverage.TabIndex = 5;
            lblAverage.Text = "Avg";
            lblAverage.Visible = false;
            // 
            // grpResults
            // 
            grpResults.BackColor = Color.FromArgb(151, 126, 82);
            grpResults.Controls.Add(imgRancher);
            grpResults.Controls.Add(lblAverage);
            grpResults.Controls.Add(lblSum);
            grpResults.Controls.Add(lblFlavor);
            grpResults.Location = new Point(-8, 685);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(816, 200);
            grpResults.TabIndex = 6;
            grpResults.TabStop = false;
            // 
            // lblFlavor
            // 
            lblFlavor.Location = new Point(195, 48);
            lblFlavor.Name = "lblFlavor";
            lblFlavor.Size = new Size(562, 120);
            lblFlavor.TabIndex = 1;
            lblFlavor.Text = "Howdy, pardner! Looks like you've got some eggs ta count! ";
            // 
            // imgRancher
            // 
            imgRancher.Image = Properties.Resources.rancherHappy;
            imgRancher.Location = new Point(33, 48);
            imgRancher.Name = "imgRancher";
            imgRancher.Size = new Size(120, 120);
            imgRancher.SizeMode = PictureBoxSizeMode.StretchImage;
            imgRancher.TabIndex = 0;
            imgRancher.TabStop = false;
            // 
            // imgChicken1
            // 
            imgChicken1.BackColor = Color.Transparent;
            imgChicken1.Image = Properties.Resources.chicken;
            imgChicken1.Location = new Point(200, 175);
            imgChicken1.Name = "imgChicken1";
            imgChicken1.Size = new Size(150, 150);
            imgChicken1.SizeMode = PictureBoxSizeMode.Zoom;
            imgChicken1.TabIndex = 7;
            imgChicken1.TabStop = false;
            // 
            // imgChicken2
            // 
            imgChicken2.BackColor = Color.Transparent;
            imgChicken2.Image = Properties.Resources.chicken;
            imgChicken2.Location = new Point(200, 466);
            imgChicken2.Name = "imgChicken2";
            imgChicken2.Size = new Size(150, 150);
            imgChicken2.SizeMode = PictureBoxSizeMode.Zoom;
            imgChicken2.TabIndex = 8;
            imgChicken2.TabStop = false;
            // 
            // imgChicken3
            // 
            imgChicken3.BackColor = Color.Transparent;
            imgChicken3.Image = Properties.Resources.chicken;
            imgChicken3.Location = new Point(450, 175);
            imgChicken3.Name = "imgChicken3";
            imgChicken3.Size = new Size(150, 150);
            imgChicken3.SizeMode = PictureBoxSizeMode.Zoom;
            imgChicken3.TabIndex = 9;
            imgChicken3.TabStop = false;
            // 
            // imgChicken4
            // 
            imgChicken4.BackColor = Color.Transparent;
            imgChicken4.Image = Properties.Resources.chicken;
            imgChicken4.Location = new Point(450, 466);
            imgChicken4.Name = "imgChicken4";
            imgChicken4.Size = new Size(150, 150);
            imgChicken4.SizeMode = PictureBoxSizeMode.Zoom;
            imgChicken4.TabIndex = 10;
            imgChicken4.TabStop = false;
            // 
            // imgWood
            // 
            imgWood.Image = Properties.Resources.wood;
            imgWood.Location = new Point(-8, -8);
            imgWood.Name = "imgWood";
            imgWood.Size = new Size(816, 166);
            imgWood.SizeMode = PictureBoxSizeMode.StretchImage;
            imgWood.TabIndex = 11;
            imgWood.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Goudy Stout", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(0, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(800, 60);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Chicken Counter";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(325, 403);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 35);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Get countin'!";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Lab2_ChickenEggs
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.straw;
            ClientSize = new Size(800, 877);
            Controls.Add(btnSubmit);
            Controls.Add(lblTitle);
            Controls.Add(imgWood);
            Controls.Add(imgChicken4);
            Controls.Add(imgChicken3);
            Controls.Add(imgChicken2);
            Controls.Add(imgChicken1);
            Controls.Add(grpResults);
            Controls.Add(numChicken3);
            Controls.Add(numChicken4);
            Controls.Add(numChicken2);
            Controls.Add(numChicken1);
            Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "Lab2_ChickenEggs";
            Text = "Chicken Counter";
            ((System.ComponentModel.ISupportInitialize)numChicken1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChicken2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChicken4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChicken3).EndInit();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgRancher).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgChicken4).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgWood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numChicken1;
        private NumericUpDown numChicken2;
        private NumericUpDown numChicken4;
        private NumericUpDown numChicken3;
        private Label lblSum;
        private Label lblAverage;
        private GroupBox grpResults;
        private PictureBox imgChicken1;
        private PictureBox imgChicken2;
        private PictureBox imgChicken3;
        private PictureBox imgChicken4;
        private PictureBox imgWood;
        private Label lblTitle;
        private Label lblFlavor;
        private PictureBox imgRancher;
        private Button btnSubmit;
    }
}