using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Hide_And_Seek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string placeToHiding) : base(name, hot)
        {
            PlaceToHiding = placeToHiding;
        }

        public string PlaceToHiding { get; }

        public override string Description => base.Description += " Можно спрятаться " + PlaceToHiding;
    }
}
