using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a menu item
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price of menue item
        /// </summary>
         double Price { get; }

        /// <summary>
        /// Calories of menu item
        /// </summary>
         uint Calories { get; }

        /// <summary>
        /// Ingredients contained in menu item
        /// </summary>
         List<string> Ingredients { get; }

    }
}
