using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public event PropertyChangedEventHandler PropertyChanged;

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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            special.Add("Hold Pick");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Hold ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            special.Add("Hold Ketchup");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Hold mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            special.Add("Hold Mustard");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
            special.Add("Hold Lettuce");
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold tomato
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
            special.Add("Hold Tomato");
            this.tomato = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold onion
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
            special.Add("Hold Onion");
            this.onion = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold mayo
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
            special.Add("Hold Mayo");
            this.mayo = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Entree name as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
