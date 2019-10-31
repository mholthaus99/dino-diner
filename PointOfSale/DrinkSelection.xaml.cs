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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
            HideAllButtons();
            foreach (UIElement elem in DrinkWrapPanel.Children)
            {
                Button btn = (Button)elem;
                btn.Click += this.DrinkItemSelected;
            }

         
        }

        private Drink drink;

        private void DrinkItemSelected(object sender, RoutedEventArgs e)
        {
            drink = null;
            Button btn = (Button)sender;
            string itemName = btn.Content.ToString();

            switch (itemName)
            {
                case "Water":
                    drink = new Water();
                    break;
                case "Jurassic Java":
                    drink = new JurassicJava();
                    break;
                case "Sodasaurus":
                    drink = new Sodasaurus();
                    break;
                case "Tyrannotea":
                    drink = new Tyrannotea();
                    break;

            }

            if (drink != null)
            {
                   if (DataContext is Order order)
                {
                    order.OrderItems.Add(drink as IMenuItem);
                    CollectionViewSource.GetDefaultView(order.OrderItems).MoveCurrentToLast();
                }
            }

        }

        private void SizeClicked(object sender, RoutedEventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            string sizeName = btn.Content.ToString();

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.OrderItems).CurrentItem is Drink theDrink)
                {
                    switch (sizeName)
                    {
                        case "Small":
                            theDrink.Size = DinoDiner.Menu.Size.Small;
                            break;
                        case "Medium":
                            theDrink.Size = DinoDiner.Menu.Size.Medium;
                            break;
                        case "Large":
                            theDrink.Size = DinoDiner.Menu.Size.Large;
                            break;
                    }
                }
            }
        }

        private void LemonClick(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.OrderItems).CurrentItem is Water water)
                {
                    water.AddLemon();
                }
                if (CollectionViewSource.GetDefaultView(order.OrderItems).CurrentItem is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
            }
        }
        private void SweetClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.OrderItems).CurrentItem is Tyrannotea tea)
                {
                    tea.Sweet = true;
                }
            }
        }

        private void DecafClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.OrderItems).CurrentItem is JurassicJava java)
                {
                    java.Decaf = true;
                }
            }
        }
    

        private void DoneClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SodaClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            FlavorButton.Visibility = Visibility.Visible;
        }

        private void TeaClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            SweetButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Visible;

        }

        private void JavaClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            DecafButton.Visibility = Visibility.Visible;
        }

        private void WaterClick(object sender, RoutedEventArgs e)
        {
            HideAllButtons();
            LemonButton.Visibility = Visibility.Visible;
        }

        private void HideAllButtons()
        {
            FlavorButton.Visibility = Visibility.Collapsed;
            SweetButton.Visibility = Visibility.Collapsed;
            LemonButton.Visibility = Visibility.Collapsed;
            DecafButton.Visibility = Visibility.Collapsed;
        }

        private void FlavorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SodaFlavorSelection());
        }

    }
}
