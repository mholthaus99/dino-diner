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

            Ingredients.Add("steakburger pattie");
            if (bun) Ingredients.Add("whole-wheat bun");
            if (pickle) Ingredients.Add("pickle");
            if (ketchup) Ingredients.Add("ketchup");
            if (mustard) Ingredients.Add("mustard");

        }

        public void HoldBun()
        {
            this.bun = false;
        }
        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        public void HoldMustard()
        {
            this.mustard = true;
        }
    }
}
