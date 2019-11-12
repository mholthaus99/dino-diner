using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// SteakosaurusBurger entree class
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem, IOrderItem
    {

        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// SteakosaurusBurger constructor
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
            //Ingredients = new List<string>();
            ingredients.Add("Steakburger Pattie");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");

        }

        /// <summary>
        /// Hold bun
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            special.Add("Hold Bun");
            this.bun = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Hold pickle
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
            special.Add("Hold Pickle");
            this.pickle = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Hold ketchup
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
            special.Add("Hold Ketchup");
            this.ketchup = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Hold mustard
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
            special.Add("Hold Mustard");
            this.mustard = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Entree name as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
