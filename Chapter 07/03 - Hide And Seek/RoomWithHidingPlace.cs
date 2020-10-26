using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Hide_And_Seek
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string PlaceToHiding { get; private set; }

        public RoomWithHidingPlace(string name, string decoration, string placeToHiding) : base(name, decoration)
        {
            PlaceToHiding = placeToHiding;
        }

        public override string Description => base.Description += " Здесь можно спрятаться " + PlaceToHiding;
    }
}
