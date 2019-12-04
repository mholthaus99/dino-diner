using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {

        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                menuItems.AddRange(AvailableCombos);
                menuItems.AddRange(AvailableEntrees);
                menuItems.AddRange(AvailableSides);
                menuItems.AddRange(AvailableDrinks);
                return menuItems;
            }
        }

        /// <summary>
        /// Generates and returns a list of all available entrees on the menu.
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                return new List<IMenuItem>
                {
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new Brontowurst(),
                    new PterodactylWings(),
                    new DinoNuggets(),
                    new VelociWrap(),
                    new PrehistoricPBJ()
                };
            }
        }

        /// <summary>
        /// Generates and returns a list of all available sides on the menu.
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                return new List<IMenuItem>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
        }

        /// <summary>
        /// Generates and returns a list of all available drinks on the menu.
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                return new List<IMenuItem>
                {
                    new Sodasaurus(),
                    new JurassicJava(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }

        /// <summary>
        /// Generates and returns a list of all available combos on the menu.
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();

                foreach (Entree entree in AvailableEntrees)
                {
                    combos.Add(new CretaceousCombo(entree));
                }

                return combos;
            }
        }

        /// <summary>
        /// Returns the entire contents of the menu separated by new line characters.
        /// </summary>
        /// <returns>A list of all menu contents separated by new line characters.</returns>
        public override string ToString()
        {
            return "hey";
        }

        public List<IMenuItem> Search(List<IMenuItem> items, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            if (term != "")
            {
                foreach (IMenuItem currentItem in items)
                {
                    string currentItemString = currentItem.ToString().ToLower();
                    if (currentItemString.Contains(term.ToLower()))
                    {
                        results.Add(currentItem);
                    }
                }
            }
            return results;
        }

        public List<string> PossibleIngredients
        {
            get
            {
                HashSet<string> availableIngredients = new HashSet<string>();
                foreach (IMenuItem menuItem in AvailableMenuItems)
                {
                    foreach (string ingredient in menuItem.Ingredients)
                    {
                        availableIngredients.Add(ingredient);
                    }
                }
                return new List<string>(availableIngredients);
            }
        }

        /// <summary>
        /// Filter by specific menu category that user chooses e.g. entree, side, combo, drink
        /// </summary>
        /// <param name="items"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMenuCategory(List<IMenuItem> items, List<string> filter)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem currentItem in items)
            {
                if (currentItem is Entree && filter.Contains("Entree"))
                {
                    results.Add(currentItem);
                }
                if (currentItem is Drink && filter.Contains("Drink"))
                {
                    results.Add(currentItem);
                }
                if (currentItem is Side && filter.Contains("Side"))
                {
                    results.Add(currentItem);
                }
                if (currentItem is CretaceousCombo && filter.Contains("Combo"))
                {
                    results.Add(currentItem);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters by min price specified by user
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> items, float min)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem currentItem in items)
            {
                if (currentItem.Price >= min)
                {
                    results.Add(currentItem);
                }
            }

            return results;
        }

        /// <summary>
        /// Filtesr by max price specified by user
        /// </summary>
        /// <param name="items"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> items, float max)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem currentItem in items)
            {
                if (currentItem.Price <= max)
                {
                    results.Add(currentItem);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters by excluded ingredients specified by user
        /// </summary>
        /// <param name="items"></param>
        /// <param name="excludedIngredients"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByExcludedIngredients(List<IMenuItem> items, List<string> excludedIngredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            bool good = true;
            foreach (IMenuItem currentItem in items)
            {
                foreach (string badIngredient in excludedIngredients)
                {
                    if (currentItem.Ingredients.Contains(badIngredient))
                    {
                        good = false;
                        break;
                    }
                }

                if (good)
                {
                    results.Add(currentItem);
                }
            }

            return results;
        }
    }

}

