﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings :Entree
    {
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;

            Ingredients.Add("chicken");
            Ingredients.Add("wing sauce");
        }
    }
}
