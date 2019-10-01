using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Tyrannotea : Drink
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
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
        }

        private bool sweet;
        public bool Sweet
        {
            get
            {
                return this.sweet;
            }
            set
            {
                this.sweet = value;
                if (value == true)
                {
                    Calories *= 2;
                }
            }
        }
        public bool Lemon { get; set; }
        public Tyrannotea() 
        {
            Price = 0.99;
            Calories = 8;

            Sweet = false;
            Lemon = false;
            Ice = true;
            //Ingredients = new List<string>();
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
        }

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
