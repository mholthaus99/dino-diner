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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
      
        public EntreeSelection()
        {
            InitializeComponent();
           
            foreach(UIElement elem in WrapPanel.Children)
            {
                Button btn = (Button)elem;
                btn.Click += this.EntreeItemSelected;
            }
        }

        private void EntreeItemSelected(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                Button btn = (Button)sender;
                string itemName = btn.Content.ToString();

                switch (itemName)
                {
                    case "Brontowurst":
                        Brontowurst bronto = new Brontowurst();
                        order.Add(bronto);
                        NavigationService.Navigate(new CustomizeBronto(bronto));
                        break;
                    case "Dino-Nuggets":
                        DinoNuggets nuggets = new DinoNuggets();
                        order.Add(nuggets);
                        NavigationService.Navigate(new CustomizeNugget(nuggets));
                        break;
                    case "Steakosaurus Burger":
                        SteakosaurusBurger steak = new SteakosaurusBurger();
                        order.Add(steak);
                        NavigationService.Navigate(new CustomizeSteak(steak));
                        break;
                    case "T-Rex King Burger":
                        TRexKingBurger tRex = new TRexKingBurger();
                        order.Add(tRex);
                        NavigationService.Navigate(new CustomizeTRex(tRex));
                        break;
                    case "Prehistoric PB&J":
                        PrehistoricPBJ pbj = new PrehistoricPBJ();
                        order.Add(pbj);
                        NavigationService.Navigate(new CustomizePBJ(pbj));
                        break;
                    case "Veloci-Wrap":
                        VelociWrap veloci = new VelociWrap();
                        order.Add(veloci);
                        NavigationService.Navigate(new CustomizeVeloci(veloci));
                        break;
                    case "Pterodactyl Wings":
                        order.Add(new PterodactylWings());
                        break;
                }
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
    }
}
