using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu { 
    /// <summary>
    /// Brontowurst entree class
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
                special.Add("Hold Bun");
            }
            this.bun = false;
            this.NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold peppers, remove it from ingredients
        /// </summary>
        public void HoldPeppers()
        {
            if (peppers)
            {
                ingredients.Remove("Peppers");
                special.Add("Hold Peppers");
            }
            this.peppers = false;
            this.NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold onion, remove it from ingredients
        /// </summary>
        public void HoldOnion()
        {
            if (onions)
            {
                ingredients.Remove("Onion");
                special.Add("Hold Onion");
            }
            this.onions = false;
            this.NotifyOfPropertyChanged("Special");
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
