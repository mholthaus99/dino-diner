using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    class Menu
    {
        public List<IMenuItem> AvailableMenuItems { get; }
        public List<IMenuItem> AvailableEntrees { get; }
        public List<IMenuItem> AvailableDrinks { get; }
        public List<IMenuItem> AvailableSides { get; }

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
    }
}
