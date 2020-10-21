using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Party_Planner_3._0
{
    class Party
    {
        public const decimal CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public virtual decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12) totalCost += 100m;

                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
            return costOfDecorations;
        }


    }
}
