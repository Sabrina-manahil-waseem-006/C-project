namespace final
{
    partial class gravity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gravity));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            roundedButton1 = new CustomRoundButton.RoundedButton();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(493, 42);
            label1.Name = "label1";
            label1.Size = new Size(339, 83);
            label1.TabIndex = 0;
            label1.Text = "GRAVITY";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Text", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(493, 105);
            label2.Name = "label2";
            label2.Size = new Size(326, 36);
            label2.TabIndex = 1;
            label2.Text = "A Gentle Hug From Earth";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(38, 154);
            label3.Name = "label3";
            label3.Size = new Size(554, 586);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Black;
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderRadius = 10;
            roundedButton1.DisabledTextColor = Color.Silver;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Algerian", 15.75F);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(1122, 620);
            roundedButton1.Margin = new Padding(0);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(163, 50);
            roundedButton1.TabIndex = 3;
            roundedButton1.Text = "BACK";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(717, 227);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(484, 294);
            axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(38, 116);
            button1.Name = "button1";
            button1.Size = new Size(41, 35);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gravity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(roundedButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "gravity";
            Text = "gravity";
            Load += gravity_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private CustomRoundButton.RoundedButton roundedButton1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button button1;
    }
}