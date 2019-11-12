using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// DinoNuggets entree class
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem
    { 
        /// <summary>
        /// gets/sets the nugget count
        /// </summary>
        public int NuggetCount { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// adds nugget to side order
        /// </summary>
        public void AddNugget()
        {
            ingredients.Add("Chicken Nugget");
            NuggetCount++;
            Calories += 59;
            Price += 0.25;

            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// DinoNuggets constructor
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 6 * 59;
            NuggetCount = 6;

            for (int i = 0; i <= 5; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
        }

        public new string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (NuggetCount > 6)
                {
                    special.Add($"{NuggetCount - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Entree name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
