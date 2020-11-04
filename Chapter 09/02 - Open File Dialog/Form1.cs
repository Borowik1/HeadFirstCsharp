using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___Open_File_Dialog
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog1;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\MyFolder\Default\";
            openFileDialog1.Filter = "Text Files(*.txt)| *.txt | "
            + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.FileName = "default_file.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //OpenSomeFile(openFileDialog1.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"c:\MyFolder\Default\";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|"
            + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //SaveTheFile(saveFileDialog1.FileName);
            }
        }
    }
}
