using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water drink class
    /// </summary>
    public class Water : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size _size;
        /// <summary>
        /// gets/sets size of the drink
        /// </summary>
        public override Size Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Water constructor
        /// </summary>
        public Water()
        {
            
            Calories = 0;
            Price = 0.10;

            ingredients.Add("Water");
        }

        private bool lemon = false;

        /// <summary>
        /// gets Lemon property.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
        }

        /// <summary>
        /// adds Lemon
        /// </summary>
        public void AddLemon()
        {
            ingredients.Add("Lemon");
            special.Add("Add Lemon");
            lemon = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Drink name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.SizeToString() + " " + "Water";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
