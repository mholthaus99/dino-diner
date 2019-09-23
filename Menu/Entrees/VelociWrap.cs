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

            Ingredients.Add("flour tortilla");
            Ingredients.Add("chicken breast");

            if (dressing) Ingredients.Add("ceasar dressing");
            if (lettuce) Ingredients.Add("romaine lettuce");
            if (cheese) Ingredients.Add("parmesan cheese");
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        public void HoldCheese()
        {
            this.cheese = false;
        }
  
    }
}
