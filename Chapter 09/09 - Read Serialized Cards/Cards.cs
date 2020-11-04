
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Read_Serialized_Cards
{
    [Serializable]
    class Cards
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
        public Cards(Suits suit, Values value)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
