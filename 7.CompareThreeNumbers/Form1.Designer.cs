namespace _7.CompareThreeNumbers
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            meowB = new Button();
            fnoTB = new TextBox();
            SnoTB = new TextBox();
            tnoTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Untitled_design;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 99);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 1;
            label1.Text = "FirstNumber:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 181);
            label2.Name = "label2";
            label2.Size = new Size(153, 30);
            label2.TabIndex = 2;
            label2.Text = "ThirdNumber:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 141);
            label3.Name = "label3";
            label3.Size = new Size(173, 30);
            label3.TabIndex = 3;
            label3.Text = "SecondNumber:";
            // 
            // meowB
            // 
            meowB.Image = Properties.Resources.cat_purr_icon;
            meowB.Location = new Point(256, 225);
            meowB.Name = "meowB";
            meowB.Size = new Size(191, 135);
            meowB.TabIndex = 4;
            meowB.UseVisualStyleBackColor = true;
            meowB.Click += meowTB_Click;
            // 
            // fnoTB
            // 
            fnoTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fnoTB.Location = new Point(256, 96);
            fnoTB.Name = "fnoTB";
            fnoTB.Size = new Size(191, 33);
            fnoTB.TabIndex = 5;
            // 
            // SnoTB
            // 
            SnoTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SnoTB.Location = new Point(256, 142);
            SnoTB.Name = "SnoTB";
            SnoTB.Size = new Size(191, 33);
            SnoTB.TabIndex = 6;
            // 
            // tnoTB
            // 
            tnoTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tnoTB.Location = new Point(256, 182);
            tnoTB.Name = "tnoTB";
            tnoTB.Size = new Size(191, 33);
            tnoTB.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 501);
            Controls.Add(tnoTB);
            Controls.Add(SnoTB);
            Controls.Add(fnoTB);
            Controls.Add(meowB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button meowB;
        private TextBox fnoTB;
        private TextBox SnoTB;
        private TextBox tnoTB;
    }
}