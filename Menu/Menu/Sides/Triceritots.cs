using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Triceritots side class
    /// </summary>
    public class Triceritots : Side, IMenuItem, IOrderItem
    {
        private Size size = Size.Small;

        public event PropertyChangedEventHandler PropertyChanged;

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
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }

                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }


        /// <summary>
        /// Triceritots constructor
        /// </summary>
        public Triceritots() 
        {
            Calories = 352;
            Price = 0.99;

            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");

        }

        /// <summary>
        ///Side name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.SizeToString() + " " + "Triceritots";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
