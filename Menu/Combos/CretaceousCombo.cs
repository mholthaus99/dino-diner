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

        /// <summary>
        /// init with entree
        /// </summary>
        /// <param name="_entree"></param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }

        public double Price => throw new NotImplementedException();

        public uint Calories => throw new NotImplementedException();

        public List<string> Ingredients => throw new NotImplementedException();

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
