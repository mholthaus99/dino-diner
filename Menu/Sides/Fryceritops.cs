using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
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
                this.size = value;
                switch (value)
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
         
            // Ingredients = new List<string>();
            Ingredients.Add("Potato");
            Ingredients.Add("Vegetable Oil");
            Ingredients.Add("Salt");
        }
    }
}
