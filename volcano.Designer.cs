namespace final
{
    partial class volcano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volcano));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            roundedButton2 = new CustomRoundButton.RoundedButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(807, 217);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(522, 286);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 40);
            label2.Name = "label2";
            label2.Size = new Size(355, 69);
            label2.TabIndex = 2;
            label2.Text = "VOLCANO";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(532, 109);
            label4.Name = "label4";
            label4.Size = new Size(295, 35);
            label4.TabIndex = 4;
            label4.Text = "A Giant Fiery Mountain";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 182);
            label5.Name = "label5";
            label5.Size = new Size(527, 431);
            label5.TabIndex = 5;
            label5.Text = resources.GetString("label5.Text");
            label5.Click += label5_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick_1;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.Black;
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.BorderRadius = 10;
            roundedButton2.DisabledTextColor = Color.Gray;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Algerian", 15.75F);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(1122, 616);
            roundedButton2.Margin = new Padding(0);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(161, 49);
            roundedButton2.TabIndex = 6;
            roundedButton2.Text = "Back";
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(147, 126);
            button1.Name = "button1";
            button1.Size = new Size(46, 53);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // volcano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(roundedButton2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "volcano";
            Text = "volcano";
            Load += volcano_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label label2;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private CustomRoundButton.RoundedButton roundedButton2;
        private Button button1;
    }
}