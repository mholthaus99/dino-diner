using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water drink class
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// gets/sets size of the drink
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Water constructor
        /// </summary>
        public Water()
        {
            
            Calories = 0;
            Price = 0.10;
         
            Ingredients.Add("Water");
        }

        private bool lemon = false;

        /// <summary>
        /// gets Lemon property.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
        }

        /// <summary>
        /// adds Lemon
        /// </summary>
        public void AddLemon()
        {
            Ingredients.Add("Lemon");
            lemon = true;
        }
       
    }
}
