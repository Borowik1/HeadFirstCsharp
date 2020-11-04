using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12___Excuse_Manager_2._0
{
    public partial class Form1 : Form
    {
        private bool formChanged;
        private Excuse currentExcuse;
        private string selectedFolder = "";
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse = new Excuse();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        public void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    //FileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }


        private void openFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                saveFileButton.Enabled = true;
                openFileButton.Enabled = true;
                randomButton.Enabled = true;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and a result",
                "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Excuse files (*.excuse)|*.excuse|All files (*.*)|*.*";
            saveFileDialog1.FileName = description.Text + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName, currentExcuse);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Excuse files (*.excuse)|*.excuse|All files (*.*)|*.*";
                openFileDialog1.FileName = description.Text + ".excuse";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            currentExcuse = new Excuse(random, selectedFolder);
            UpdateForm(false);
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                "The current excuse has not been saved. Continue?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }
    }
}
