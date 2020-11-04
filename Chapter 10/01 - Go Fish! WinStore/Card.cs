
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Go_Fish__WinStore
{
    class Card
    {
        public Values Value { get; set; }
        public Suits Suit { get; set; }
        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
        public Card(Suits suit, Values value)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return Name;
        }

        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}
