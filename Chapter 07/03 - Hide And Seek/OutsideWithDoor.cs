using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Hide_And_Seek
{
    class OutsideWithDoor : OutsideWithHidingPlace, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string placeToHiding, string doorDescription) : base(name, hot, placeToHiding)
        {
            DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public override string Description => base.Description += "Вы видите " + DoorDescription + ". ";
    }
}
