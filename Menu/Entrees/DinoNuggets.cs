﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets entree class
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem
    { 
        /// <summary>
        /// gets/sets the nugget count
        /// </summary>
        public int NuggetCount { get; set; }

        /// <summary>
        /// adds nugget to side order
        /// </summary>
        public void AddNugget()
        {
            NuggetCount++;
            Calories += 59;
            Price += 0.25;
            Ingredients.Add("Chicken Nugget");
        }

        /// <summary>
        /// DinoNuggets constructor
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 6 * 59;
            NuggetCount = 6;

            for (int i = 0; i <= 5; i++)
            {
                Ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// Entree name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
