﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace final
{
    public partial class volcano : Form
    {
        private SoundPlayer sp;
        private bool isplaying;
        private int currentLabelIndex = 0;
        private string text;

        public volcano()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            sp = new SoundPlayer(@" E:\oop projecct\volcano.wav");
            this.FormBorderStyle = FormBorderStyle.None;


        }



        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private async void volcano_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            text = label5.Text;
            label5.Text = "";
            timer1.Interval = 70;
            timer1.Start();

        }
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (currentLabelIndex < text.Length)
            {
                label5.Text = label5.Text + text.ElementAt(currentLabelIndex);
                currentLabelIndex++;
            }
            else
            {
                timer1.Stop(); // Stop the timer when all labels have been shown
            }
        }

        
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            sp.Stop();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isplaying == true)
            {
                sp.Stop();
                isplaying = false;
                Image backgroundImage = Image.FromFile(@"E:\oop projecct\stop.jpg");
                button1.BackgroundImage = backgroundImage;

                // Set the BackgroundImageLayout to Stretch
                button1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                sp.Play();
                isplaying = true;
                Image backgroundImage = Image.FromFile(@"E:\oop projecct\play.jpg");
                button1.BackgroundImage = backgroundImage;

                // Set the BackgroundImageLayout to Stretch
                button1.BackgroundImageLayout = ImageLayout.Stretch;

            }
        }

    }
}
