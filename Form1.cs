namespace tp3kpl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = textBox1.Text;

            label1.Text = "Halo, " + input;
        }
    }
}
