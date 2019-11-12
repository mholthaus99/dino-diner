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
    /// Interaction logic for CustomizeBronto.xaml
    /// </summary>
    public partial class CustomizeBronto : Page
    {
        private Brontowurst bronto;
        public CustomizeBronto()
        {
            InitializeComponent();
        }

        public CustomizeBronto(Brontowurst bronto)
        {
            this.bronto = bronto;
            InitializeComponent();
        }

        private void Click_HBun(object sender, RoutedEventArgs e)
        {
            bronto.HoldBun();
        }

        private void Click_HPeppers(object sender, RoutedEventArgs e)
        {
            bronto.HoldPeppers();
        }

        private void Click_HOnion(object sender, RoutedEventArgs e)
        {
            bronto.HoldOnion();
        }

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            NavigationService.GoBack();
        }
    }
}
