﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
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
                        Price = 0.99;
                        Calories = 420;  
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        public MeteorMacAndCheese() 
        {
            Calories = 420;
            Price = 0.99;
        
            // Ingredients = new List<string>();
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");

        }
    }
}
