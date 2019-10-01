using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        
        public override Size Size { get; set; }

        public Water()
        {
            
            Calories = 0;
            Price = 0.10;
         
            Ingredients.Add("Water");
        }

        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
        }

        public void AddLemon()
        {
            Ingredients.Add("Lemon");
            lemon = true;
        }
       
    }
}
