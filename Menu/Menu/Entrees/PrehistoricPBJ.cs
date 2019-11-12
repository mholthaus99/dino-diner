using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// PrehistoricPBJ entree class
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem, IOrderItem
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public event PropertyChangedEventHandler PropertyChanged;

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
            special.Add("Hold Peanut Butter");
            
            this.peanutButter = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Hold jelly, remove if from ingredients
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
            special.Add("Hold Jelly");
            this.jelly = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Entree name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
