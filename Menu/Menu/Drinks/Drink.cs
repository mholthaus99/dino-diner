using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    /*
    /// <summary>
    /// Drink size
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// Small
        /// </summary>
        Small,
        /// <summary>
        /// Medium
        /// </summary>
        Medium,
        /// <summary>
        /// Large
        /// </summary>
        Large
    }
    */
    /// <summary>
    /// Base class for Drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// ingrediants accessible from inherited class
        /// </summary>
        protected readonly List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return new List<string>(ingredients);
            }

        }

        /// <summary>
        /// Size as string
        /// </summary>
        /// <returns></returns>
        public string SizeToString()
        {
            switch (this.Size)
            {
                case Size.Small:
                    return "Small";
                case Size.Medium:
                    return "Medium";
                case Size.Large:
                    return "Large";
                default:
                    return "";
            }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        private bool ice = true;
        /// <summary>
        /// Gets or sets ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return this.ice;
            }
            set
            {
                this.ice = value;

            }
        }

     /// <summary>
     /// Holds ice in drink
     /// </summary>
        public void HoldIce()
        {
            this.ice = false;
        }

    }
}
