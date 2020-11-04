using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03___Simple_Text_Editor
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"Text files (*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }


        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);                
            }
        }
    }
}
