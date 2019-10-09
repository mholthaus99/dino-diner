using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// TRexKingBurger entree class
    /// </summary>
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

        /// <summary>
        /// TRexKingBurger constructor
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;

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

        /// <summary>
        /// Hold bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            Ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Hold pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            Ingredients.Remove("Pickle");
        }
        /// <summary>
        /// Hold ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            Ingredients.Remove("Ketchup");
        }
        /// <summary>
        /// Hold mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            Ingredients.Remove("Mustard");
        }

        /// <summary>
        /// Hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            Ingredients.Remove("Lettuce");
            this.lettuce = false;
        }

        /// <summary>
        /// Hold tomato
        /// </summary>
        public void HoldTomato()
        {
            Ingredients.Remove("Tomato");
            this.tomato = false;
        }

        /// <summary>
        /// Hold onion
        /// </summary>
        public void HoldOnion()
        {
            Ingredients.Remove("Onion");
            this.onion = false;
        }

        /// <summary>
        /// Hold mayo
        /// </summary>
        public void HoldMayo()
        {
            Ingredients.Remove("Mayo");
            this.mayo = false;
        }
    }
}
