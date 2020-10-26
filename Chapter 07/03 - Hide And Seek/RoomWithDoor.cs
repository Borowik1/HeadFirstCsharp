using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Hide_And_Seek
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string placeToHiding, string doorDescription) : base(name, decoration, placeToHiding)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}
