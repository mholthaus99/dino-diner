using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;

            Ingredients.Add("bread");
            if (peanutButter) Ingredients.Add("peanut butter");
            if (jelly) Ingredients.Add("jelly");

        }

        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
