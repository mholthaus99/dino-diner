using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// JurrasicJava class
    /// JurassicJava
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

       // public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// JurrasicJava constructor
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;

            ingredients.Add("Water");
            ingredients.Add("Coffee");

            Ice = false;

        }
       

        private bool roomForCream = false;
        private bool decaf = false;

        /// <summary>
        /// gets/sets decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return this.decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// gets RoomForCream property
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                
                return this.roomForCream;
            }
        }

      

        /// <summary>
        /// Leaves room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            roomForCream = true;
            special.Add("Leave Room For Cream");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Adds ice to drink
        /// </summary>
        public void AddIce()
        {
            special.Add("Add Ice");
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Drink name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string drinkName = "Jurassic Java";
            
            if (Decaf == true)
            {
                drinkName = "Decaf Jurassic Java";
            }

            //Decaf Jurassic Java

            return base.SizeToString() + " " + drinkName;
        }

        /*
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        */
    }
}
