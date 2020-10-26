using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Hide_And_Seek
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public string Decoration { get; set; }
        public override string Description
        {
            get
            {
                return base.Description + " Здесь вы видете " + decoration + ". ";                
            }
        }
    }
}
