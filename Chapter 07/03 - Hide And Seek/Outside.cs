using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Hide_And_Seek
{
    class Outside : Location
    {
        private bool hot;
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
        public bool Hot { get { return hot; } }
        public override string Description
        {
            get
            {
                string description = base.Description;
                if (Hot) description += " Тут очень жарко. ";
                return description;
            }
            
        }
    }
}
