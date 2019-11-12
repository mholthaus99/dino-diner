using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
            foreach(UIElement elem in ComboWrapPanel.Children)
            {
                Button btn = (Button)elem;
                btn.Click += this.ComboChoiceSelected;
            }
        }

        private void ComboChoiceSelected(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Button btn = (Button)sender;
                string itemName = btn.Content.ToString();
                CretaceousCombo combo = new CretaceousCombo(new Brontowurst());

                switch (itemName)
                {
                    case "Brontowurst Combo":
                         combo = new CretaceousCombo(new Brontowurst());
                        order.Add(combo);
                        NavigationService.Navigate(new ComboCustomize(combo));
                        break;
                    case "Dino-Nuggets Combo":
                        combo = new CretaceousCombo(new DinoNuggets());
                        order.Add(combo);
                        NavigationService.Navigate(new ComboCustomize(combo));
                        break;
                    case "Steakosaurus Burger Combo":
                         combo = new CretaceousCombo(new SteakosaurusBurger());
                        order.Add(combo);
                        NavigationService.Navigate(new ComboCustomize(combo));
                        break;
                    case "T-Rex King Burger Combo":
                         combo = new CretaceousCombo(new TRexKingBurger());
                        order.Add(combo);
                        NavigationService.Navigate(new ComboCustomize(combo));
                        break;
                    case "Prehistoric PB&J Combo":
                         combo = new CretaceousCombo(new PrehistoricPBJ());
                        order.Add(combo);
                        NavigationService.Navigate(new ComboCustomize(combo));
                        break;
                    case "Veloci-Wrap Combo":
                         combo = new CretaceousCombo(new VelociWrap());
                        order.Add(combo);
                        NavigationService.Navigate(new ComboCustomize(combo));
                        break;
                    case "Pterodactyl Wings Combo":
                         combo = new CretaceousCombo(new PterodactylWings());
                        order.Add(combo);
                        NavigationService.Navigate(new ComboCustomize(combo));
                        break;
                }
            }
        }
    }
}
