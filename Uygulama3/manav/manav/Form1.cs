using System.Windows.Forms;

namespace manav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste.Items.Add(textBox1.Text);
        }
    }
}