using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04___Beehive_Management
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJobBox.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }

        private void nextShiftButton_Click(object sender, EventArgs e)
        {
            reportTextBox.Text = queen.WorkTheNextShift();
        }

        private void assignJobButton_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJobBox.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для этого задания рабочих нет ‘"
                + workerBeeJobBox.Text + "’", "Матка говорит...");
            else
                MessageBox.Show("Задание ‘" + workerBeeJobBox.Text + "’ будет закончено через "
                + shifts.Value + " смен", "Матка говорит...");
        }
    }
}
