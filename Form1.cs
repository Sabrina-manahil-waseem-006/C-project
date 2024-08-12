using System.Runtime.InteropServices;
namespace final
{
    public partial class Form1 : Form
    {

        public void SetMessage(string textFromForm1)
        {
            label1.Text = $"HELLO {textFromForm1.ToUpper()} ! SELECT ANY TOPIC OF YOUR CHOICE FROM THE LIST BELOW!";
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
          int nLeft,      // x-coordinate of upper-left corner
          int nTop,       // y-coordinate of upper-left corner
          int nRight,     // x-coordinate of lower-right corner
          int nBottom,    // y-coordinate of lower-right corner
          int nWidthEllipse,  // height of ellipse
          int nHeightEllipse  // width of ellipse
);

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
        }

        //for preventing fluctuation
        protected override CreateParams CreateParams
        {
            get
            {
                //the CreateParams property is overridden, which is inherited from the Control class. This allows to set custom window parameters
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED is a Windows extended style that enables double-buffering for the window. 
                return cp;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {   // button round
            //In GDI programming, a region (HRGN) is typically used to define an irregularly shaped area
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
        }


        private void button4_Click(object sender, EventArgs e)
        {    // new form open
            solar s = new solar();
            s.Show();
        }

        private void VOLCANO_Click(object sender, EventArgs e)
        {   }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            volcano v = new volcano();
            v.Show();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            rainbow r = new rainbow();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gravity g = new gravity();
            g.Show();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            quiz q = new quiz();
            q.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            quiz q = new quiz();
            q.Show();
        }
    }
}
