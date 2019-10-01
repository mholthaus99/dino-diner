using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// drink sizez
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

    /// <summary>
    /// Base class of Side
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }


        private readonly List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients {
            get
            {
                return this.ingredients;
            }
                
                }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; } 


    }
}
