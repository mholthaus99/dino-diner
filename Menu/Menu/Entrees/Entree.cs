using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree base class
    /// </summary>
    public abstract class Entree: IMenuItem, IOrderItem
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
        /// 
        /// </summary>
        protected readonly List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        /// 
        public List<string> Ingredients
        {
            get
            {

                return new List<string>(ingredients);
            }
        }

        /// <summary>
        /// Gets the description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Special list for derived classes.
        /// </summary>
        protected readonly List<string> special = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// special details on item
        /// </summary>
        public string[] Special
        {
            get
            {
                return this.special.ToArray();
            }
        }

    }
}
