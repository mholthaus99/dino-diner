﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
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
                if (sweet) { Calories *= 2; }
            }
        }

        private bool sweet = false;
        public bool Sweet
        {
            get
            {
                return this.sweet;
            }
            set
            {
                //adding sweetener
                if (value == true && this.sweet == false)
                {
                    Calories *= 2;
                    Ingredients.Add("Cane Sugar");
                    this.sweet = value;
                }
                //removing sweetener
                if(value == false && this.sweet == true)
                {
                    Calories /= 2;
                    Ingredients.Remove("Cane Sugar");
                    this.sweet = value;
                }
            }
        }
        private bool lemon = false;

        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
        }

        public Tyrannotea() 
        {
            Price = 0.99;
            Calories = 8;

            Ingredients.Add("Water");
            Ingredients.Add("Tea");
        }

        public void AddLemon()
        {
            Ingredients.Add("Lemon");
            this.lemon = true;
        }
    }
}
