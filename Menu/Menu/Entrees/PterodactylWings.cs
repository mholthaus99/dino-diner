using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// PterodactylWings entree class
    /// </summary>
    public class PterodactylWings :Entree, IMenuItem, IOrderItem
    {
        /// <summary>
        /// PterodatylWings constructor
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
      
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Entree name as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
