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
    /// Interaction logic for CustomizePBJ.xaml
    /// </summary>
    public partial class CustomizePBJ : Page
    {
        private PrehistoricPBJ _pbj;

        public CustomizePBJ()
        {
            InitializeComponent();
        }

        public CustomizePBJ(PrehistoricPBJ pbj)
        {
            this._pbj = pbj;
            InitializeComponent();
        }

        private void Click_HPB(object sender, RoutedEventArgs e)
        {
            _pbj.HoldPeanutButter();
        }

        private void Click_HJelly(object sender, RoutedEventArgs e)
        {
            _pbj.HoldJelly();
        }

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            NavigationService.GoBack();
        }
    }
}
