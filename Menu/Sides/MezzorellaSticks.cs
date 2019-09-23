using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }

        public MezzorellaSticks()
        {
            Calories = 540;
            Price = 0.99;

            Ingredients.Add("cheese product");
            Ingredients.Add("breading");
            Ingredients.Add("vegetable oil");

        }
    }
}
