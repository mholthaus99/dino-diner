using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola, Orange, Vanilla, Chocolate, RootBeer, Cherry, Lime
    }
    public class Sodasaurus : Drink
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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        public SodasaurusFlavor Flavor;

        public Sodasaurus() 
        {
            Price = 1.50;
            Calories = 112;

            Ice = true;
            //Ingredients = new List<string>();
            
            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }

    }
}
