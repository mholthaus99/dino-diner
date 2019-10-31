using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// TRexKingBurger entree class
    /// </summary>
    public class TRexKingBurger: Entree, IMenuItem, IOrderItem
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

            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
            if (lettuce) ingredients.Add("Lettuce");
            if (tomato) ingredients.Add("Tomato");
            if (onion) ingredients.Add("Onion");
            if (mayo) ingredients.Add("Mayo");
        }

        /// <summary>
        /// Hold bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            ingredients.Remove("Whole Wheat Bun");
            special.Add("Hold Bun");
        }

        /// <summary>
        /// Hold pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            special.Add("Hold Pick");
        }
        /// <summary>
        /// Hold ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            special.Add("Hold Ketchup");
        }
        /// <summary>
        /// Hold mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            special.Add("Hold Mustard");
        }

        /// <summary>
        /// Hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
            special.Add("Hold Mustard");
            this.lettuce = false;
        }

        /// <summary>
        /// Hold tomato
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
            special.Add("Hold Tomato");
            this.tomato = false;
        }

        /// <summary>
        /// Hold onion
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
            special.Add("Hold Onion");
            this.onion = false;
        }

        /// <summary>
        /// Hold mayo
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
            special.Add("Hold Mayo");
            this.mayo = false;
        }

        /// <summary>
        /// Entree name as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
