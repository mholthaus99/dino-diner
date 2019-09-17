using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        public Fryceritops()
        {
            Calories = 222;
            Price = 0.99;

        }

    }
}
