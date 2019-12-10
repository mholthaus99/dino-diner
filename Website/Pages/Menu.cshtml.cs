using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {

        public Menu M { get; private set; }

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        public List<IMenuItem> AvailableCombos { get; private set; } = null;
        public List<IMenuItem> AvailableEntrees { get; private set; } = null;
        public List<IMenuItem> AvailableSides { get; private set; } = null;
        public List<IMenuItem> AvailableDrinks { get; private set; } = null;

        public List<Size> Sizes = new List<Size>();

        public void OnGet()
        {
            M = new Menu();
         
        }

        public void OnPost()
        {
            M = new Menu();

            Sizes.Add(Size.Small);
            Sizes.Add(Size.Medium);
            Sizes.Add(Size.Large);

            if (menuCategory.Count > 0)
            {
                if (menuCategory.Contains("Combo"))
                {
                    AvailableCombos = M.AvailableMenuItems.OfType<CretaceousCombo>().Cast<IMenuItem>().ToList();    //ToList();
                }
                if (menuCategory.Contains("Entree"))
                {
                    AvailableEntrees = M.AvailableMenuItems.OfType<Entree>().Cast<IMenuItem>().ToList();
                }
                if (menuCategory.Contains("Side"))
                {
                    AvailableSides = M.AvailableMenuItems.OfType<Side>().Cast<IMenuItem>().ToList();
                }
                if (menuCategory.Contains("Drink"))
                {
                    AvailableDrinks = M.AvailableMenuItems.OfType<Drink>().Cast<IMenuItem>().ToList();
                }
            }

            if (search != null)
            {
                AvailableCombos = AvailableCombos?.Where(item => item.ToString().Contains(search)).ToList();
                AvailableEntrees = AvailableEntrees?.Where(item => item.ToString().Contains(search)).ToList();
                AvailableSides = AvailableSides?.Where(item => item.ToString().Contains(search)).ToList();
                AvailableDrinks = AvailableDrinks?.Where(item => item.ToString().Contains(search)).ToList();
            }

            if (minimumPrice is float min)
            {
                AvailableCombos = AvailableCombos?.Where(item => item.Price > min).ToList();
                AvailableEntrees = AvailableEntrees?.Where(item => item.Price > min).ToList();
                AvailableSides = AvailableSides?.Where(item => item.Price > min).ToList();
                AvailableDrinks = AvailableDrinks?.Where(item => item.Price > min).ToList();
            }

            if (maximumPrice is float max)
            {
                AvailableCombos = AvailableCombos?.Where(item => item.Price < max).ToList();
                AvailableEntrees = AvailableEntrees?.Where(item => item.Price < max).ToList();
                AvailableSides = AvailableSides?.Where(item => item.Price < max).ToList();
                AvailableDrinks = AvailableDrinks?.Where(item => item.Price < max).ToList();
            }

         
            if (excludedIngredients.Count > 0)
            {
                foreach (string s in excludedIngredients)
                {
                    AvailableCombos = AvailableCombos?.Where(item => !item.Ingredients.Contains(s)).ToList();
                    AvailableEntrees = AvailableEntrees?.Where(item => !item.Ingredients.Contains(s)).ToList();
                    AvailableSides = AvailableSides?.Where(item => !item.Ingredients.Contains(s)).ToList();
                    AvailableDrinks = AvailableDrinks?.Where(item => !item.Ingredients.Contains(s)).ToList();
                }
            }
        }
    }
}