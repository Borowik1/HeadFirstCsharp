using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___Guys
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public void UpdateForm()
        {
            joeCashLabel.Text = joe.Name + " имеет $" + joe.Cash;
            bobCashLabel.Text = bob.Name + " имеет $" + bob.Cash;
            bankCashLabel.Text = "В банке сейчас $" + bank;
        }
        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 50, Name = "Joe" };

            bob = new Guy() { Cash = 100, Name = "Bob" };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReciveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("В банке нет денег");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash > 10)
            {
                joe.GiveCash(10);
                bob.ReciveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("У Джо недостаточно денег");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash > 5)
            {
                bob.GiveCash(5);
                joe.ReciveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("У Боба недостаточно денег");
            }
        }
    }
}
