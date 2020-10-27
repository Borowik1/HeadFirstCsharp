using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Cards
{
    public partial class Form1 : Form
    {
        Cards card;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card = new Cards((Suits)random.Next(0, 4), (Values)random.Next(1, 14));
            MessageBox.Show(card.Name);
        }
    }
}
