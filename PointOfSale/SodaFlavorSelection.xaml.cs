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
    /// Interaction logic for SodaFlavorSelection.xaml
    /// </summary>
    public partial class SodaFlavorSelection : Page
    {
        public SodaFlavorSelection()
        {
            InitializeComponent();

            foreach (UIElement elem in WrapPanel.Children)
            {
                Button btn = (Button)elem;
                btn.Click += this.SelectDrink;
            }
        }

        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    Button btn = (Button)sender;
                    string flavorName = btn.Content.ToString();

                    switch (flavorName)
                    {
                        case "Cherry":
                            soda.Flavor = SodasaurusFlavor.Cherry;
                            break;
                        case "Chocolate":
                            soda.Flavor = SodasaurusFlavor.Chocolate;
                            break;
                        case "Cola":
                            soda.Flavor = SodasaurusFlavor.Cola;
                            break;
                        case "Lime":
                            soda.Flavor = SodasaurusFlavor.Lime;
                            break;
                        case "Orange":
                            soda.Flavor = SodasaurusFlavor.Orange;
                            break;
                        case "Root Beer":
                            soda.Flavor = SodasaurusFlavor.RootBeer;
                            break;
                        case "Vanilla":
                            soda.Flavor = SodasaurusFlavor.Vanilla;
                            break;
                           

                    }
                    NavigationService.GoBack();
                }
            }
        }
    }
}
