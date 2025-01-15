using System.Data;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            textBox1.Text += currentButton.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var d = new DataTable();
            textBox1.Text = d.Compute(textBox1.Text, "").ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

       
    }
}
