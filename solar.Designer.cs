namespace final
{
    partial class solar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solar));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            roundedButton1 = new CustomRoundButton.RoundedButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(382, 38);
            label1.Name = "label1";
            label1.Size = new Size(553, 68);
            label1.TabIndex = 0;
            label1.Text = "SOLAR SYSTEM\r\n\r\n";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Text", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(484, 106);
            label2.Name = "label2";
            label2.Size = new Size(317, 44);
            label2.TabIndex = 1;
            label2.Text = "A Big Cosmic Playground";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(40, 191);
            label3.Name = "label3";
            label3.Size = new Size(770, 491);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(836, 182);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(490, 286);
            axWindowsMediaPlayer1.TabIndex = 3;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Black;
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderRadius = 10;
            roundedButton1.DisabledTextColor = Color.Gray;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Algerian", 15.75F);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(1179, 573);
            roundedButton1.Margin = new Padding(0);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(163, 45);
            roundedButton1.TabIndex = 4;
            roundedButton1.Text = "Back";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(40, 131);
            button1.Name = "button1";
            button1.Size = new Size(46, 46);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // solar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(roundedButton1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "solar";
            Text = "solar";
            Load += solar_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private CustomRoundButton.RoundedButton roundedButton1;
        private Button button1;
    }
}