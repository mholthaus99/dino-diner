using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// PrehistoricPBJ entree class
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// PrehistoricPBJ constructor
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;

           // Ingredients = new List<string>();
            Ingredients.Add("Bread");
            if (peanutButter) Ingredients.Add("Peanut Butter");
            if (jelly) Ingredients.Add("Jelly");

        }

        /// <summary>
        /// Hold peanut butter, remove it from ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
                Ingredients.Remove("Peanut Butter");
            
            this.peanutButter = false;
        }

        /// <summary>
        /// Hold jelly, remove if from ingredients
        /// </summary>
        public void HoldJelly()
        {
            Ingredients.Remove("Jelly");
            this.jelly = false;
        }

        /// <summary>
        /// Entree name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
