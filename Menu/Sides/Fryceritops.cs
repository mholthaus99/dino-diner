using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Fryceritops side class
    /// </summary>
    public class Fryceritops : Side, IMenuItem
    {

        private Size size = Size.Small;
        
        /// <summary>
        /// gets/sets the side size
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// Fryceritops constructor
        /// </summary>
        public Fryceritops()
        {
            
            Calories = 222;
            Price = 0.99;
         
           
            Ingredients.Add("Potato");
            Ingredients.Add("Vegetable Oil");
            Ingredients.Add("Salt");
        }

        /// <summary>
        /// Side name as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.SizeToString() + " " + "Fryceritops";
        }
    }
}
