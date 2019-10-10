using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a combo
    /// </summary>
    public class CretaceousCombo: IMenuItem
    {
        /// <summary>
        /// Entree of the combo
        /// </summary>
        public Entree Entree { get; set; }

        private Drink _drink;
        private Side _side;

        /// <summary>
        /// init with entree
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }

        /// <summary>
        /// Combo price
        /// </summary>
        public double Price
        {
            get
            {
                return this.Entree.Price + this._drink.Price + this._side.Price;
               
            }
        }

        /// <summary>
        /// Combo total calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return this.Entree.Calories + this._drink.Calories + this._side.Calories;
            }
        }

        /// <summary>
        /// All ingredients in combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> allIngredients = new List<string>();
                allIngredients.AddRange(this.Entree.Ingredients);
                allIngredients.AddRange(this._side.Ingredients);
                allIngredients.AddRange(this._drink.Ingredients);
                return allIngredients;
            }
        }

        /// <summary>
        /// Add side to combo
        /// </summary>
        /// <param name="side"></param>
        public void AddSide(Side side)
        {
            this._side = side;
        }

        /// <summary>
        /// Add drink to side;
        /// </summary>
        /// <param name="drink"></param>
        public void AddDrink(Drink drink)
        {
            this._drink = drink;
        }

        /// <summary>
        /// Combo name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Entree.ToString() + " " + "Combo";
        }
    }
}
