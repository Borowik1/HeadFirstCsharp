
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Methods_Overload

{
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

        public static bool DoesCardMatch(Cards cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }
        public static bool DoesCardMatch(Cards cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }

    }
}
