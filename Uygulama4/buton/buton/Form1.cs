using Microsoft.VisualBasic.Devices;

namespace buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse artýk üzerimde deðildir.");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse üzerimdedir.");
        }
    }
}