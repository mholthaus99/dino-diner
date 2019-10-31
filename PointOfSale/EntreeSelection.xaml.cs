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
                        order.OrderItems.Add(new Brontowurst());
                        break;
                    case "Dino-Nuggets":
                        order.OrderItems.Add(new DinoNuggets());
                        break;
                    case "Steakosaurus Burger":
                        order.OrderItems.Add(new SteakosaurusBurger());
                        break;
                    case "T-Rex King Burger":
                        order.OrderItems.Add(new TRexKingBurger());
                        break;
                    case "Prehistoric PB&J":
                        order.OrderItems.Add(new PrehistoricPBJ());
                        break;
                    case "Veloci-Wrap":
                        order.OrderItems.Add(new VelociWrap());
                        break;
                    case "Pterodactyl Wings":
                        order.OrderItems.Add(new PterodactylWings());
                        break;
                }
                CollectionViewSource.GetDefaultView(order.OrderItems).MoveCurrentToLast();
                NavigationService.GoBack();
            }
        }
    }
}
