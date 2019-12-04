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

        public void OnGet()
        {
            M = new Menu();
        }

        public void OnPost()
        {
            M = new Menu();
            AvailableCombos = M.AvailableCombos;
            AvailableSides = M.AvailableSides;
            AvailableDrinks = M.AvailableDrinks;
            AvailableEntrees = M.AvailableEntrees;

            if (search != null)
            {
                AvailableCombos = M.Search(AvailableCombos, search);
                AvailableEntrees = M.Search(AvailableEntrees, search);
                AvailableSides = M.Search(AvailableSides, search);
                AvailableDrinks = M.Search(AvailableDrinks, search);
            }

            if (menuCategory.Count > 0)
            {
                AvailableCombos = M.FilterByMenuCategory(AvailableCombos, menuCategory);
                AvailableEntrees = M.FilterByMenuCategory(AvailableEntrees, menuCategory);
                AvailableSides = M.FilterByMenuCategory(AvailableSides, menuCategory);
                AvailableDrinks = M.FilterByMenuCategory(AvailableDrinks, menuCategory);
            }

         
            if (minimumPrice is float min)
            {
                AvailableCombos = M.FilterByMinPrice(AvailableCombos, min);
                AvailableEntrees = M.FilterByMinPrice(AvailableEntrees, min);
                AvailableDrinks = M.FilterByMinPrice(AvailableDrinks, min);
                AvailableSides = M.FilterByMinPrice(AvailableSides, min);
            }

          
            if (maximumPrice is float max)
            {
                AvailableCombos = M.FilterByMaxPrice(AvailableCombos, max);
                AvailableEntrees = M.FilterByMaxPrice(AvailableEntrees, max);
                AvailableDrinks = M.FilterByMaxPrice(AvailableDrinks, max);
                AvailableSides = M.FilterByMaxPrice(AvailableSides, max);
            }

         
            if (excludedIngredients.Count > 0)
            {
                AvailableCombos = M.FilterByExcludedIngredients(AvailableCombos, excludedIngredients);
                AvailableEntrees = M.FilterByExcludedIngredients(AvailableEntrees, excludedIngredients);
                AvailableDrinks = M.FilterByExcludedIngredients(AvailableDrinks, excludedIngredients);
                AvailableSides = M.FilterByExcludedIngredients(AvailableSides, excludedIngredients);
            }
        }
    }
}