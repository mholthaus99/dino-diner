using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Order object
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Items
        /// </summary>
        public ObservableCollection<IMenuItem> OrderItems {get; protected set;} = new ObservableCollection<IMenuItem>();

        /// <summary>
        /// Idk honestly
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creates new order instance
        /// </summary>
        public Order()
        {
            this.OrderItems.CollectionChanged += this.OnCollectionChanged;

        }

        /// <summary>
        /// Subtotal cost
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach(IMenuItem item in OrderItems)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Collection Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
