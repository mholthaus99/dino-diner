using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea drink class
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        private Size size = Size.Small;

        /// <summary>
        /// gets/sets size of drink
        /// </summary>
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

        /// <summary>
        /// gets/sets drink sweet property
        /// </summary>
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
                    ingredients.Add("Cane Sugar");
                    this.sweet = value;
                }
                //removing sweetener
                if(value == false && this.sweet == true)
                {
                    Calories /= 2;
                    ingredients.Remove("Cane Sugar");
                    this.sweet = value;
                }
            }
        }
        private bool lemon = false;

        /// <summary>
        /// gets Lemon property
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
        }


        /// <summary>
        /// Tyrannotea constructor
        /// </summary>
        public Tyrannotea() 
        {
            Price = 0.99;
            Calories = 8;

            ingredients.Add("Water");
            ingredients.Add("Tea");
        }


        /// <summary>
        /// Adds Lemon
        /// </summary>
        public void AddLemon()
        {
            ingredients.Add("Lemon");
            this.lemon = true;
        }

         //   if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.ToString());
         //   else Assert.Equal($"{size} Tyrannotea", tea.ToString());

        /// <summary>
        /// Drink name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sweetString = " ";
            if (this.sweet)
            {
                sweetString = " Sweet ";
            }
            return base.SizeToString() + sweetString + "Tyrannotea";
        }
    }
}
