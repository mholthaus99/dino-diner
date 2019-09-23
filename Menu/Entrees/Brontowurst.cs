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

            Ingredients.Add("brautwurst");
            if (bun) Ingredients.Add("Whole-Wheat Bun");
            if (peppers) Ingredients.Add("Peppers");
            if (onions) Ingredients.Add("Onions");
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
