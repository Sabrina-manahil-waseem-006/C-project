using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Media;

namespace final
{

    public partial class quiz : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adap;
        DataSet d;
        int currentQuestionIndex = 0;
        int rd1_index = 0;
        int rd2_index = 0;
        int rd3_index = 0;
        int rd4_index = 0;
        private SoundPlayer cor;
        private SoundPlayer incor;

        public quiz()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            cor = new SoundPlayer(@"E:\oop projecct\right.wav");
            incor = new SoundPlayer(@"E:\oop projecct\error.wav");
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None; //to remove top bar

        }

        //for preventing fluctuation
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quiz_Load(object sender, EventArgs e)
        {
            incor.Stop();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            button1.Visible = false;
            button2.Visible = true;

            // Initialize database connection and data adapter
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/quiz.accdb");
            adap = new OleDbDataAdapter("SELECT * FROM quizoop", con);
            d = new DataSet();

            // Fill the DataSet with data from the database
            adap.Fill(d, "quizoop");

            // Display the first question
            DisplayCurrentQuestion();


        }



        private void DisplayCurrentQuestion()
        {
            if (d.Tables["quizoop"].Rows.Count > 0)
            {
                DataRow row = d.Tables["quizoop"].Rows[currentQuestionIndex];
                label2.Text = $"Question: {row["Question"].ToString()}";
                radioButton1.Text = $"A) {row["option a"].ToString()}";
                radioButton2.Text = $"B) {row["option b"].ToString()}";
                radioButton3.Text = $"C) {row["option c"].ToString()}";
                radioButton4.Text = $"D) {row["option d"].ToString()}";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //next wala btn
        private void button1_Click(object sender, EventArgs e)
        {
            // Move to the next question if available
            pictureBox1.Visible = false;
            label3.Visible = false;
            if (currentQuestionIndex < d.Tables["quizoop"].Rows.Count - 1)
            {
                currentQuestionIndex++;
                rd1_index++;
                rd2_index++;
                rd3_index++;
                rd4_index++;
                DisplayCurrentQuestion();
            }
            else
            {
                label2.Text = " ";
                radioButton1.Text = " ";
                radioButton2.Text = " ";
                radioButton3.Text = " ";
                radioButton4.Text = " ";
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                MessageBox.Show("You have reached the end of the questions.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                DataRow row = d.Tables["quizoop"].Rows[currentQuestionIndex];
                string correctAnswer = row["correct option"].ToString();
                // Remove prefix (A), (B), (C), (D) before comparing
                string selectedAnswer = radioButton.Text.Substring(3);

                if (selectedAnswer == correctAnswer)
                {
                    label3.Visible = true;
                    label3.Text = "Great Job!";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\corr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cor.Play();
                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Wrong Answer!";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\incorr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                DataRow row = d.Tables["quizoop"].Rows[currentQuestionIndex];
                string correctAnswer = row["correct option"].ToString();
                // Remove prefix (A), (B), (C), (D) before comparing
                string selectedAnswer = radioButton.Text.Substring(3);

                if (selectedAnswer == correctAnswer)
                {
                    label3.Visible = true;
                    label3.Text = "Great Job!";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\corr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cor.Play();
                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Wrong Answer!";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\incorr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    incor.Play();
                }
            }
        }



        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                DataRow row = d.Tables["quizoop"].Rows[currentQuestionIndex];
                string correctAnswer = row["correct option"].ToString();
                // Remove prefix (A), (B), (C), (D) before comparing
                string selectedAnswer = radioButton.Text.Substring(3);

                if (selectedAnswer == correctAnswer)
                {
                    label3.Visible = true;
                    label3.Text = "Great Job!";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\corr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cor.Play();
                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Wrong Answer!";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\incorr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    incor.Play();    
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                DataRow row = d.Tables["quizoop"].Rows[currentQuestionIndex];
                string correctAnswer = row["correct option"].ToString();
                // Remove prefix (A), (B), (C), (D) before comparing
                string selectedAnswer = radioButton.Text.Substring(3);

                if (selectedAnswer == correctAnswer)
                {
                    label3.Visible = true;
                    pictureBox1.Visible = true;
                    label3.Text = "Great Job!"; 
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\corr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cor.Play();

                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Wrong Answer!";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"E:\oop projecct\incorr.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    incor.Play();
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        //home btn
        private void button2_Click(object sender, EventArgs e)
        {
             
            Form1 f = new Form1();
            f.Show();
            f.SetMessage("");
            this.Close();
        }

        //lets go btn
        private void button3_Click(object sender, EventArgs e)
        {
           
            radioButton1.Checked = false;
            label1.Visible = true;
            label2.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            radioButton1.Checked = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        
    }
}

