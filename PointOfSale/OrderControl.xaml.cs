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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
         
        }

        /*
        private void MountItemListener()
        {
            if (DataContext is Order order)
            {
                order.OrderItems.CollectionChanged += OnCollectionChanged;
            }
        }
        */

        private void OnRemoveOrderItem(object sender, RoutedEventArgs args)
        {
            var elemDataContext = (sender as FrameworkElement).DataContext;

            if (DataContext is Order order)
            {
                if (elemDataContext is IOrderItem item)
                {
                    order.Remove(item);
                }
            }
           
        }
    }
}
