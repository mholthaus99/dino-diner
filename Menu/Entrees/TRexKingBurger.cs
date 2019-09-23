using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger: Entree
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;

            Ingredients.Add("3 steakburger patties");
            if (bun) Ingredients.Add("Whole-wheat bun");
            if (pickle) Ingredients.Add("Pickle");
            if (ketchup) Ingredients.Add("Ketchup");
            if (mustard) Ingredients.Add("Mustard");
            if (lettuce) Ingredients.Add("Lettuce");
            if (tomato) Ingredients.Add("Tomato");
            if (onion) Ingredients.Add("Onion");
            if (mayo) Ingredients.Add("Mayo");
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.bun = false;
        }
        public void HoldKetchup()
        {
            this.bun = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
