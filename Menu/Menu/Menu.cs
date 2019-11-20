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
        public List<Entree> AvailableEntrees
        {
            get
            {
                return new List<Entree>
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
        public List<Side> AvailableSides
        {
            get
            {
                return new List<Side>
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
        public List<Drink> AvailableDrinks
        {
            get
            {
                return new List<Drink>
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
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>();

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
        /*
        public List<IMenuItem> AvailableMenuItems { get; }
        public List<IMenuItem> AvailableEntrees { get; }
        public List<IMenuItem> AvailableDrinks { get; }
        public List<IMenuItem> AvailableSides { get; }

        public List<IMenuItem> AvailableCombos { get; }

        public Menu()
        {
            AvailableEntrees.Add(new Brontowurst());
            AvailableEntrees.Add(new DinoNuggets());
            AvailableEntrees.Add(new PrehistoricPBJ());
            AvailableEntrees.Add(new PterodactylWings());
            AvailableEntrees.Add(new SteakosaurusBurger());
            AvailableEntrees.Add(new TRexKingBurger());
            AvailableEntrees.Add(new VelociWrap());

            AvailableSides.Add(new Fryceritops());
            AvailableSides.Add(new MeteorMacAndCheese());
            AvailableSides.Add(new MezzorellaSticks());
            AvailableSides.Add(new Triceritots());

            AvailableDrinks.Add(new JurassicJava());
            AvailableDrinks.Add(new Sodasaurus());
            AvailableDrinks.Add(new Tyrannotea());
            AvailableDrinks.Add(new Water());

            AvailableCombos.Add(new CretaceousCombo(new Brontowurst()));

            AvailableMenuItems.AddRange(AvailableCombos);
            AvailableMenuItems.AddRange(AvailableEntrees);
            AvailableMenuItems.AddRange(AvailableDrinks);
            AvailableMenuItems.AddRange(AvailableSides);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(IMenuItem item in AvailableMenuItems)
            {
                sb.Append(item.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
        */
    }
}
