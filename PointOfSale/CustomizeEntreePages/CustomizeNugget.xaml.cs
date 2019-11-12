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
    /// Interaction logic for CustomizeNugget.xaml
    /// </summary>
    public partial class CustomizeNugget : Page
    {
        private DinoNuggets _nuggets;
        public CustomizeNugget()
        {
            InitializeComponent();
        }

        public CustomizeNugget(DinoNuggets nuggets)
        {
            this._nuggets = nuggets;
            InitializeComponent();
        }

        private void Click_ANugget(object sender, RoutedEventArgs e)
        {
            _nuggets.AddNugget();
        }

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            NavigationService.GoBack();
        }
    }
}
