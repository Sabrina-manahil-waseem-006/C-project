namespace final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sitka Small", 48F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(888, 194);
            button4.Name = "button4";
            button4.Size = new Size(279, 107);
            button4.TabIndex = 3;
            button4.Text = "SOLAR ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 48F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(63, 506);
            button1.Name = "button1";
            button1.Size = new Size(383, 94);
            button1.TabIndex = 6;
            button1.Text = "VOLCANO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Azure;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(90, 204);
            button2.Name = "button2";
            button2.Size = new Size(389, 87);
            button2.TabIndex = 7;
            button2.Text = "RAINBOW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Small", 48F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(828, 506);
            button3.Name = "button3";
            button3.Size = new Size(363, 94);
            button3.TabIndex = 8;
            button3.Text = "GRAVITY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(107, 25);
            label1.Name = "label1";
            label1.Size = new Size(29, 43);
            label1.TabIndex = 14;
            label1.Text = ".";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Black", 13F);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(548, 357);
            button5.Name = "button5";
            button5.Size = new Size(246, 100);
            button5.TabIndex = 16;
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button5;
    }
}
