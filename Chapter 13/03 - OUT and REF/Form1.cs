using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03___OUT_and_REF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ReturnTreeValues(out double half, out int twice)
        {
            Random random = new Random();
            int value = random.Next(1000);
            half = value / 2;
            twice = value * 2;
            return value;
        }

        public void ModifyAnIntAndButton(ref int value, ref Button button)
        {
            int i = value;
            i *= 5;
            value = i - 3;
            button = button1;
        }

        public void CheckTemperature(double temp, double tooHigh = 37.5, double tooLow = 35.5)
        {
            if (temp < tooLow || temp > tooHigh)
                Console.WriteLine("Call a doctor!!!");
            else
                Console.WriteLine("I'm fine!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            double b;
            int c;
            a = ReturnTreeValues(out b, out c);

            Console.WriteLine("value={0}, half={1}, double={2}", a, b, c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = 100;
            Button b = button1;
            ModifyAnIntAndButton(ref q, ref b);
            Console.WriteLine("q={1}, b.Text={1}", q, b.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double temp = 37.6;
            double tooHigh = 37.6;
            double tooLow = 35.4;
            CheckTemperature(temp, tooLow: tooLow);
        }
    }
}
