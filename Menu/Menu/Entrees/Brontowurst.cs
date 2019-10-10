using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu { 
    /// <summary>
    /// Brontowurst entree class
    /// </summary>
    public class Brontowurst : Entree, IMenuItem
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Brontowurst constructor
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;

            ingredients.Add("Brautwurst");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (peppers) ingredients.Add("Peppers");
            if (onions) ingredients.Add("Onion");
           
        }

        /// <summary>
        /// Hold bun, remove it from ingredients
        /// </summary>
        public void HoldBun()
        {
            if (bun)
            {
                ingredients.Remove("Whole Wheat Bun");
            }
            this.bun = false;
        }

        /// <summary>
        /// Hold peppers, remove it from ingredients
        /// </summary>
        public void HoldPeppers()
        {
            if (peppers)
            {
                ingredients.Remove("Peppers");
            }
            this.peppers = false;
        }

        /// <summary>
        /// Hold onion, remove it from ingredients
        /// </summary>
        public void HoldOnion()
        {
            if (onions)
            {
                ingredients.Remove("Onion");
            }
            this.onions = false;
        }

        /// <summary>
        /// Entree name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
