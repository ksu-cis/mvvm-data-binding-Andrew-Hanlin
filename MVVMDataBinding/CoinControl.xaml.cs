using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
//using MVVMDataBinding;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {  
        public CoinControl()
        {
            InitializeComponent();
        }
     
        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        public static readonly DependencyProperty DenominationProperty =
       DependencyProperty.Register(
           "Denomination",                     // The name of the property
           typeof(Coins),                      // The type of the property
           typeof(CoinControl),                // The property's control
           new PropertyMetadata(Coins.Penny)   // The Property Medata
           );

        public static readonly DependencyProperty QuantityProperty =
          DependencyProperty.Register(
              "Quantity",
              typeof(int),
              typeof(CoinControl),
              new FrameworkPropertyMetadata(
                  0,
                  FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
              )
          );

        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        public void OnAddClicked(object sender, RoutedEventArgs args)
        {
            Quantity++;
        }

        public void OnRemoveClicked(object sender, RoutedEventArgs args)
        {
            Quantity--;
        }
      
    }
}
