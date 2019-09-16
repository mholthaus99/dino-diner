﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "3 Steakburger Patties" };
                if (bun) ingredients.Add("Whole-wheat bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");

                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.bun = false;
        }
        public void HoldKetchup()
        {
            this.bun = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
