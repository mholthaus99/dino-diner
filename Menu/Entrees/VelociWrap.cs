using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap: Entree
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
   

        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;

           // Ingredients = new List<string>();
            Ingredients.Add("Flour Tortilla");
            Ingredients.Add("Chicken Breast");

            if (dressing) Ingredients.Add("Ceasar Dressing");
            if (lettuce) Ingredients.Add("Romaine Lettuce");
            if (cheese) Ingredients.Add("Parmesan Cheese");
        }

        public void HoldDressing()
        {
            Ingredients.Remove("Ceasar Dressing");
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            Ingredients.Remove("Romaine Lettuce");
            this.lettuce = false;
        }
        public void HoldCheese()
        {
            Ingredients.Remove("Parmesan Cheese");
            this.cheese = false;
        }
  
    }
}
