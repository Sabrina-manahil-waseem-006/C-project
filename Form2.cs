using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace final
{
    public partial class Form2 : Form
    {
        private Form1 form2Instance;
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = " ";
        }

        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form2());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void roundedButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label4.Text = "Please Enter name to proceed :D";
            }
            else
            {
                string textFromForm1 = textBox1.Text;

                if (form2Instance == null || form2Instance.IsDisposed)
                {
                    form2Instance = new Form1();
                    form2Instance.Show(this);
                }
                else
                {
                    form2Instance.Show(this);
                }

                form2Instance.SetMessage(textFromForm1);
            }



        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
