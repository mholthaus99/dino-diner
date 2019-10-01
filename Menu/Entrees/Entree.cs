﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        private List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return this.ingredients;
            }
        }
       
    }
}