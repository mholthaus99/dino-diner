using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    { 
        public int NuggetCount { get; set; }

        public void AddNugget()
        {
            NuggetCount++;
            Calories += 59;
            Price += 0.25;
        }

        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 6 * 59;
            NuggetCount = 6;

            Ingredients.Add("chicken nuggets");
        }
    }
}
