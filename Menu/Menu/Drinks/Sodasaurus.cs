using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
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
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The drink flavor
        /// </summary>
        private SodasaurusFlavor _flavor;

        public SodasaurusFlavor Flavor
        {
            get
            {
                return _flavor;
            }
            set
            {
                _flavor = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Flavor");
            }
        }
       

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sodasaurus constructor
        /// </summary>
        public Sodasaurus() 
        {
            Price = 1.50;
            Calories = 112;

            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

        /// <summary>
        /// Drink name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string flavorName; ;

            switch (this.Flavor)
            {
                case SodasaurusFlavor.Cherry:
                    flavorName = "Cherry";
                    break;
                case SodasaurusFlavor.Chocolate:
                    flavorName = "Chocolate";
                    break;
                case SodasaurusFlavor.Cola:
                    flavorName = "Cola";
                    break;
                case SodasaurusFlavor.Lime:
                    flavorName = "Lime";
                    break;
                case SodasaurusFlavor.Orange:
                    flavorName = "Orange";
                    break;
                case SodasaurusFlavor.RootBeer:
                    flavorName = "RootBeer";
                    break;
                case SodasaurusFlavor.Vanilla:
                    flavorName = "Vanilla";
                    break;
                default:
                    flavorName = "";
                    break;
            }

           // Assert.Equal($"{size} {flavor} Sodasaurus", soda.ToString());

            return base.SizeToString() + " " + flavorName + " "+ "Sodasaurus";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
