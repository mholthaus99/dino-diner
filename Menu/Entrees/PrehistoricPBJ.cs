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

           // Ingredients = new List<string>();
            Ingredients.Add("Bread");
            if (peanutButter) Ingredients.Add("Peanut Butter");
            if (jelly) Ingredients.Add("Jelly");

        }

        public void HoldPeanutButter()
        {
            Ingredients.Remove("Peanut Butter");
            this.peanutButter = false;
        }

        public void HoldJelly()
        {
            Ingredients.Remove("Jelly");
            this.jelly = false;
        }
    }
}
