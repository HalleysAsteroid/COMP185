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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numChicken1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChicken2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChicken4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChicken3).BeginInit();
            SuspendLayout();
            // 
            // numChicken1
            // 
            numChicken1.Location = new Point(100, 76);
            numChicken1.Margin = new Padding(5);
            numChicken1.Name = "numChicken1";
            numChicken1.Size = new Size(189, 29);
            numChicken1.TabIndex = 0;
            // 
            // numChicken2
            // 
            numChicken2.Location = new Point(100, 199);
            numChicken2.Margin = new Padding(5);
            numChicken2.Name = "numChicken2";
            numChicken2.Size = new Size(189, 29);
            numChicken2.TabIndex = 1;
            // 
            // numChicken4
            // 
            numChicken4.Location = new Point(100, 477);
            numChicken4.Margin = new Padding(5);
            numChicken4.Name = "numChicken4";
            numChicken4.Size = new Size(189, 29);
            numChicken4.TabIndex = 2;
            // 
            // numChicken3
            // 
            numChicken3.Location = new Point(100, 356);
            numChicken3.Margin = new Padding(5);
            numChicken3.Name = "numChicken3";
            numChicken3.Size = new Size(189, 29);
            numChicken3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 595);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // Lab2_ChickenEggs
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 827);
            Controls.Add(label1);
            Controls.Add(numChicken3);
            Controls.Add(numChicken4);
            Controls.Add(numChicken2);
            Controls.Add(numChicken1);
            Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Lab2_ChickenEggs";
            Text = "Chicken Counter";
            ((System.ComponentModel.ISupportInitialize)numChicken1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChicken2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChicken4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChicken3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numChicken1;
        private NumericUpDown numChicken2;
        private NumericUpDown numChicken4;
        private NumericUpDown numChicken3;
        private Label label1;
    }
}