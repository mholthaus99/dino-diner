using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
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
            }
        }

        public Triceritots()
        {
            Calories = 540;
            Price = 0.99;

            Ingredients.Add("potatoes");
            Ingredients.Add("salt");
            Ingredients.Add("vegetable oil");

        }
    }
}
