using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05__Secret_Ingredients
{
    class Suzanne
    {
        public GetSecretIngredient MySecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(SuzanneSecretIngredients);
            }
        }

        private string SuzanneSecretIngredients(int amount)
        {
            return amount.ToString()+ " ounces of cloves";
        }
    }
}
