using System.IO;
using System.Windows.Forms;
using System;

namespace WinFormsApp1
{
    public partial class WinFormsApp1 : Form
    {
        public WinFormsApp1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "text files (*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                try
                {
                    string lines = File.ReadAllText(filepath, System.Text.Encoding.UTF8);
                    textBox1.Text = lines;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"вышла ошибка: {ex}");
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = saveFileDialog.FileName;
                    try
                    {
                        File.WriteAllText(filepath, textBox1.Text, System.Text.Encoding.UTF8);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}");
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";  
                if (saveFileDialog.ShowDialog() == DialogResult.OK)  
                {
                    string filepath = saveFileDialog.FileName;
                    try
                    {
                        File.WriteAllText(filepath, textBox1.Text, System.Text.Encoding.UTF8);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}");
                    }
                }
            }
        }
    }
}