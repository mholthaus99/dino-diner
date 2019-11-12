using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// MeteorMacAndCheese class
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem, IOrderItem
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
                        Calories = 420;  
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }

                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// MeteorMacAndCheese constructor
        /// </summary>
        public MeteorMacAndCheese() 
        {
            Calories = 420;
            Price = 0.99;

            ingredients.Add("Macaroni Noodles");
            ingredients.Add("Cheese Product");
            ingredients.Add("Pork Sausage");

        }

        /// <summary>
        /// Side name as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.SizeToString() + " " + "Meteor Mac and Cheese";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
