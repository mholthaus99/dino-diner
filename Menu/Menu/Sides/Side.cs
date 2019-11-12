using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
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
    public abstract class Side : IOrderItem, IMenuItem
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
        /// ingredients accessible by derived clases
        /// </summary>
        protected readonly List<string> ingredients = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients {
            get
            {
                return new List<string>(this.ingredients);
            }
                
                }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Return size as string
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
        /// Description
        /// </summary>
       public string Description
        {
            get
            {
                return this.ToString();
            }
        }



        /// <summary>
        /// Side special
        /// </summary>
        public string[] Special => new string[0];

    }
}
