using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Base class for Drinks
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged
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


        public event PropertyChangedEventHandler PropertyChanged;

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
            special.Add("Hold Ice");
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Special"));
        }

        /// <summary>
        /// Description of item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// special for use by derived classes
        /// </summary>
        protected readonly List<string> special = new List<string>();


        /// <summary>
        /// Special property for use
        /// </summary>
        public string[] Special
        {
            get
            {
                return special.ToArray();
            }
        }

    }
}
