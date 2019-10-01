using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {

        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
            //Ingredients = new List<string>();
            Ingredients.Add("Steakburger Pattie");
            if (bun) Ingredients.Add("Whole Wheat Bun");
            if (pickle) Ingredients.Add("Pickle");
            if (ketchup) Ingredients.Add("Ketchup");
            if (mustard) Ingredients.Add("Mustard");

        }

        public void HoldBun()
        {
            Ingredients.Remove("Whole Wheat Bun");
            this.bun = false;
        }
        public void HoldPickle()
        {
            Ingredients.Remove("Pickle");
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            Ingredients.Remove("Ketchup");
            this.ketchup = false;
        }
        public void HoldMustard()
        {
            Ingredients.Remove("Mustard");
            this.mustard = true;
        }
    }
}
