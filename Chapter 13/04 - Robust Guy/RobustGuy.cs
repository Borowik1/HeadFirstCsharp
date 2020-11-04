using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Robust_Guy
{
    class RobustGuy
    {
        public DateTime? Birthday { get; private set; }
        public int? Height { get; private set; }

        public RobustGuy(string birthday, string height)
        {
            DateTime tempDate;
            if (DateTime.TryParse(birthday, out tempDate))
                Birthday = tempDate;
            else
                Birthday = null;

            int tempInt;
            if (int.TryParse(height, out tempInt))
                Height = tempInt;
            else
                Height = null;
        }

        public override string ToString()
        {
            string description;
            if (Birthday.HasValue)
                description = "I was born " + Birthday.Value.ToLongDateString();
            else
                description = "I don't know when I was born";

            if (Height.HasValue)
                description += ", I'm " + Height + " cm tall";
            else
                description += ", and don't know my height";

            return description;
        }
    }
}
