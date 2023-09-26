namespace Lab1_ClickableFlags
{
    partial class Lab1_ClickableFlags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_ClickableFlags));
            pictureBox1 = new PictureBox();
            lblInstructions = new Label();
            lblFlagInfo = new Label();
            imgPoland = new PictureBox();
            imgLatvia = new PictureBox();
            imgEstonia = new PictureBox();
            grpFlags = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPoland).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLatvia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEstonia).BeginInit();
            grpFlags.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 10);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblInstructions
            // 
            lblInstructions.Anchor = AnchorStyles.Top;
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(140, 75);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(420, 23);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Click a flag to learn which country it represents. ";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            lblInstructions.Click += label1_Click;
            // 
            // lblFlagInfo
            // 
            lblFlagInfo.Anchor = AnchorStyles.None;
            lblFlagInfo.Location = new Point(300, 250);
            lblFlagInfo.Name = "lblFlagInfo";
            lblFlagInfo.Size = new Size(100, 23);
            lblFlagInfo.TabIndex = 1;
            lblFlagInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgPoland
            // 
            imgPoland.Anchor = AnchorStyles.Left;
            imgPoland.BorderStyle = BorderStyle.FixedSingle;
            imgPoland.Image = Properties.Resources.pl;
            imgPoland.Location = new Point(50, 125);
            imgPoland.Name = "imgPoland";
            imgPoland.Size = new Size(150, 100);
            imgPoland.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPoland.TabIndex = 2;
            imgPoland.TabStop = false;
            imgPoland.Click += imgPoland_Click;
            // 
            // imgLatvia
            // 
            imgLatvia.Anchor = AnchorStyles.None;
            imgLatvia.BorderStyle = BorderStyle.FixedSingle;
            imgLatvia.Image = Properties.Resources.lv;
            imgLatvia.Location = new Point(275, 125);
            imgLatvia.Name = "imgLatvia";
            imgLatvia.Size = new Size(150, 100);
            imgLatvia.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLatvia.TabIndex = 3;
            imgLatvia.TabStop = false;
            imgLatvia.Click += imgLatvia_Click;
            // 
            // imgEstonia
            // 
            imgEstonia.Anchor = AnchorStyles.Right;
            imgEstonia.BorderStyle = BorderStyle.FixedSingle;
            imgEstonia.Image = Properties.Resources.ee;
            imgEstonia.Location = new Point(500, 125);
            imgEstonia.Name = "imgEstonia";
            imgEstonia.Size = new Size(150, 100);
            imgEstonia.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEstonia.TabIndex = 4;
            imgEstonia.TabStop = false;
            imgEstonia.Click += imgEstonia_Click;
            // 
            // grpFlags
            // 
            grpFlags.Anchor = AnchorStyles.None;
            grpFlags.BackColor = Color.FromArgb(221, 221, 221);
            grpFlags.Controls.Add(imgEstonia);
            grpFlags.Controls.Add(imgLatvia);
            grpFlags.Controls.Add(imgPoland);
            grpFlags.Controls.Add(lblFlagInfo);
            grpFlags.Controls.Add(lblInstructions);
            grpFlags.Location = new Point(50, 110);
            grpFlags.Margin = new Padding(0);
            grpFlags.Name = "grpFlags";
            grpFlags.Padding = new Padding(0);
            grpFlags.Size = new Size(700, 350);
            grpFlags.TabIndex = 6;
            grpFlags.TabStop = false;
            // 
            // Lab1_ClickableFlags
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(800, 577);
            Controls.Add(grpFlags);
            Controls.Add(pictureBox1);
            Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "Lab1_ClickableFlags";
            Text = "Lab 1 - Clickable Flags";
            Load += Lab1_ClickableFlags_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPoland).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLatvia).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEstonia).EndInit();
            grpFlags.ResumeLayout(false);
            grpFlags.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblInstructions;
        private Label lblFlagInfo;
        private PictureBox imgPoland;
        private PictureBox imgLatvia;
        private PictureBox imgEstonia;
        private GroupBox grpFlags;
    }
}