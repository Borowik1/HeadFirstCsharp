using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage = 0;
        int endingMileage = 0;
        double milesTraveled = 0;
        double reimburseRate = 0.39;
        double amountOwed = 0;
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)startNumericUpDown.Value;
            endingMileage = (int)endNumericUpDown.Value;
            if (startingMileage > endingMileage)
            {
                MessageBox.Show("Начальные пробег не может превышать конечный");
            }
            else
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
