using _03___Party_Planner_3._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Party_Planner_3._0
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += (CalculateCostOfBeveragesPerPerson() * NumberOfPeople);

                if (HealthyOption)
                {
                    totalCost *= 0.95M;
                }

                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecoration;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }

    }
}
