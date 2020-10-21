using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _03___Party_Planner_3._0
{
    class BirthdayParty : Party
    {
        private const int actualLength = 0;

        public string CakeWiting { get; set; }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWiting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }
        private int ActualLength
        {
            get
            {
                if (CakeWiting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWiting.Length;
            }
        }
        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * 0.25M;
                else
                    cakeCost = 75M + ActualLength * 0.25M;

                return totalCost + cakeCost;
            }
        }
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecoration, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecoration;
            CakeWiting = cakeWriting;
        }


    }
}
