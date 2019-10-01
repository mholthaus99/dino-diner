using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public override Size Size
        {
            get
            {
                return Size;
            }
            set
            {
                Size = value;
                switch (Size)
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

        private bool RoomForCream;
        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;

           // Ingredients = new List<string>();
            Ingredients.Add("Water");
            Ingredients.Add("Coffee");

            Ice = false;
            RoomForCream = false;
            
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

    }
}
