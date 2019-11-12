using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// VelociWrap entree class
    /// </summary>
    public class VelociWrap: Entree, IMenuItem, IOrderItem
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// VelociWrap constructor
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;

            // Ingredients = new List<string>();
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");

            if (dressing) ingredients.Add("Ceasar Dressing");
            if (lettuce) ingredients.Add("Romaine Lettuce");
            if (cheese) ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// Hold dressing
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
            special.Add("Hold Dressing");
            this.dressing = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
            special.Add("Hold Lettuce");
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold cheese
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
            special.Add("Hold Cheese");
            this.cheese = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Entree name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
