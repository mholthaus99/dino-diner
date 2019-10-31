using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a combo
    /// </summary>
    public class CretaceousCombo: IMenuItem, IOrderItem
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

        /*
        The special instructions for the Entree
The description of the side
The special instructions for the Side
The description of the drink
The special instructions for the drink
*/
        

        /// <summary>
        /// Special
        /// </summary>
        public string[] Special
        {
            get
            {
               List<string> special = new List<string>();
                
                //ENTREE INSTRUCTIONS
                foreach(string s in this.Entree.Special)
                {
                    special.Add(s);
                }

                //SIDE DESCRIPTION
                special.Add(this._side.Description);

                //SIDE INSTRUCTIONS
                foreach (string s in this._side.Special)
                {
                    special.Add(s);
                }

                //DRINK DESCRIPTION
                special.Add(this._drink.Description);

                //DRINK INSTRUCTIONS
                foreach (string s in this._drink.Special)
                {
                    special.Add(s);
                }

                return special.ToArray();
            }
        }

        /// <summary>
        /// Description of combo
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
    }
}
