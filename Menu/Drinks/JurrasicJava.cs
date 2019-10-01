using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        private Size size = Size.Small;
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
            }
        }

        
        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;

            Ingredients.Add("Water");
            Ingredients.Add("Coffee");

            Ice = false;

        }
       

        private bool roomForCream = false;
        //public bool Decaf { get; set; } = true;
        
        public bool RoomForCream
        {
            get
            {
                return this.roomForCream;
            }
        }

        public void LeaveRoomForCream()
        {
            roomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }
    }
}
