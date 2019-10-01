using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public override Size Size { get; set; }

        private bool Lemon;

        public Water()
        {
            Lemon = false;
            Size = Size.Small;
            Calories = 0;
            Price = 0.10;
           // Ingredients = new List<string>();
            Ingredients.Add("Water");
        }

        public void AddLemon()
        {
            Lemon = true;
        }
       
    }
}
