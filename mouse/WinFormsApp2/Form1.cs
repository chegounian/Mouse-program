namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureb.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "right.gif"));

            }
            if (e.Button == MouseButtons.Left)
            {
                pictureb.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "left.gif"));

            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureb.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "center.gif"));

            }
         



        }
    }
}
