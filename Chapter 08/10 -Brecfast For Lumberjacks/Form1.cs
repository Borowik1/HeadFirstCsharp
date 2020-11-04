using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10__Brecfast_For_Lumberjacks
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> quene;
        public Form1()
        {
            InitializeComponent();
            quene = new Queue<Lumberjack>();
        }

        private void Redraw()
        {
            breakfastLine.Clear();
            lumberjackHave.Clear();
            int counter = 1;
            foreach (Lumberjack item in quene)
            {
                breakfastLine.Text += (counter + ". " + item.Name + "\r\n");
                counter++;
            }
            if (quene.Count != 0)
            {
                Lumberjack current = new Lumberjack(quene.Peek());
                lumberjackHave.Text = current.Name + " has " + current.FlapjackCount + " flapjacks";
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            quene.Enqueue(new Lumberjack(lumberjackName.Text));
            lumberjackName.Clear();
            Redraw();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if (quene.Count != 0)
            {
                Lumberjack vs = new Lumberjack(quene.Dequeue());
                vs.EatFlapjacs();
                Redraw();
            }
        }

        private void addFlapjack_Click(object sender, EventArgs e)
        {
            if (quene.Count == 0) return;
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;
            Lumberjack currentLumberjack = quene.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            Redraw();
        }
    }
}
