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

           // Ingredients = new List<string>();
            Ingredients.Add("Steakburger Pattie");
            Ingredients.Add("Steakburger Pattie");
            Ingredients.Add("Steakburger Pattie");
            if (bun) Ingredients.Add("Whole Wheat Bun");
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
            Ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldPickle()
        {
            this.pickle = false;
            Ingredients.Remove("Pickle");
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
            Ingredients.Remove("Ketchup");
        }
        public void HoldMustard()
        {
            this.mustard = false;
            Ingredients.Remove("Mustard");
        }

        public void HoldLettuce()
        {
            Ingredients.Remove("Lettuce");
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            Ingredients.Remove("Tomato");
            this.tomato = false;
        }

        public void HoldOnion()
        {
            Ingredients.Remove("Onion");
            this.onion = false;
        }

        public void HoldMayo()
        {
            Ingredients.Remove("Mayo");
            this.mayo = false;
        }
    }
}
