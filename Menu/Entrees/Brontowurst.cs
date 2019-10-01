using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees { 
    public class Brontowurst : Entree
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;

            //Ingredients = new List<string>();
            Ingredients.Add("Brautwurst");
            if (bun) Ingredients.Add("Whole Wheat Bun");
            if (peppers) Ingredients.Add("Peppers");
            if (onions) Ingredients.Add("Onion");
        }

        public void HoldBun()
        {
            Ingredients.Remove("Whole Wheat Bun");
            this.bun = false;
        }

        public void HoldPeppers()
        {
            Ingredients.Remove("Peppers");
            this.peppers = false;
        }

        public void HoldOnion()
        {
            Ingredients.Remove("Onion");
            this.onions = false;
        }
    }
}
