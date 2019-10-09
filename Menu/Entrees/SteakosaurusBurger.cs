using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// SteakosaurusBurger entree class
    /// </summary>
    public class SteakosaurusBurger : Entree
    {

        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// SteakosaurusBurger constructor
        /// </summary>
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

        /// <summary>
        /// Hold bun
        /// </summary>
        public void HoldBun()
        {
            Ingredients.Remove("Whole Wheat Bun");
            this.bun = false;
        }
        /// <summary>
        /// Hold pickle
        /// </summary>
        public void HoldPickle()
        {
            Ingredients.Remove("Pickle");
            this.pickle = false;
        }
        /// <summary>
        /// Hold ketchup
        /// </summary>
        public void HoldKetchup()
        {
            Ingredients.Remove("Ketchup");
            this.ketchup = false;
        }
        /// <summary>
        /// Hold mustard
        /// </summary>
        public void HoldMustard()
        {
            Ingredients.Remove("Mustard");
            this.mustard = true;
        }
    }
}
