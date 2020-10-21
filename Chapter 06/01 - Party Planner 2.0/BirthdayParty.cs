using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Party_Planner_2._0
{
    class BirthdayParty
    {
        public const decimal CostOfFoodPerPerson = 25;
        private const int actualLength = 0;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
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
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
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
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;

            return costOfDecorations;
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecoration, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecoration;
            CakeWiting = cakeWriting;
        }


    }
}
