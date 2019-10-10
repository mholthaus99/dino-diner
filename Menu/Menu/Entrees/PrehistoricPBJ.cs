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
            ingredients.Add("Bread");
            if (peanutButter) ingredients.Add("Peanut Butter");
            if (jelly) ingredients.Add("Jelly");

        }

        /// <summary>
        /// Hold peanut butter, remove it from ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
            
            this.peanutButter = false;
        }

        /// <summary>
        /// Hold jelly, remove if from ingredients
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
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
