using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {

        public double Price { get; set; }
        public uint Calories { get; set; }

        public int NuggetCount { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { NuggetCount + 
                    " Chicken Nuggets"};

                return ingredients;
            }
        }

        public void AddNugget()
        {
            NuggetCount++;
            Calories += 59;
            Price += 0.25;
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
            this.NuggetCount = 6;
        }
    }
}
