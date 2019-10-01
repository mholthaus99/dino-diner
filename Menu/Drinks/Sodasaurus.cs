using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Flavors of Sodasaurus drink
    /// </summary>
    public enum SodasaurusFlavor
    {
        /// <summary>
        /// Cola
        /// </summary>
        Cola, 
        /// <summary>
        /// Orange
        /// </summary>
        Orange, 
        /// <summary>
        /// Vanilla
        /// </summary>
        Vanilla, 
        /// <summary>
        /// Chocolate
        /// </summary>
        Chocolate, 
        /// <summary>
        /// Root Beer
        /// </summary>
        RootBeer, 
        /// <summary>
        /// Cherry
        /// </summary>
        Cherry, 
        /// <summary>
        /// Lime
        /// </summary>
        Lime
    }

    /// <summary>
    /// Sodasauras class
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size size = Size.Small;
        
        /// <summary>
        /// gets/sets size of drink
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// The drink flavor
        /// </summary>
        public SodasaurusFlavor Flavor;

        /// <summary>
        /// Sodasaurus constructor
        /// </summary>
        public Sodasaurus() 
        {
            Price = 1.50;
            Calories = 112;

            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }

    }
}
