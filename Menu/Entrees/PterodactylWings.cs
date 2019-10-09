using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// PterodactylWings entree class
    /// </summary>
    public class PterodactylWings :Entree
    {
        /// <summary>
        /// PterodatylWings constructor
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
           // Ingredients = new List<string>();
            Ingredients.Add("Chicken");
            Ingredients.Add("Wing Sauce");
        }
    }
}
