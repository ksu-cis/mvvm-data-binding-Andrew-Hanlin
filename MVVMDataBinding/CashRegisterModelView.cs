using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that notifies when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The Model class for this ModelView
        /// </summary> 
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        double TotalValue => drawer.TotalValue;

        public int Pennies
        {
            get => drawer.Pennies;
            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quanity = value - drawer.Pennies;
                if (quanity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quanity);
                }
                else { drawer.RemoveCoin(Coins.Penny, -quanity); }
                InvokePropertyChanged("Pennies");
            }

        }

        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quanity = value - drawer.Dimes;
                if (quanity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quanity);
                }
                else { drawer.RemoveCoin(Coins.Dime, -quanity); }
                InvokePropertyChanged("Dimes");
            }

        }
        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quanity = value - drawer.Nickels;
                if (quanity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quanity);
                }
                else { drawer.RemoveCoin(Coins.Nickel, -quanity); }
                InvokePropertyChanged("Nickels");
            }

        }
        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quanity = value - drawer.Quarters;
                if (quanity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quanity);
                }
                else { drawer.RemoveCoin(Coins.Quarter, -quanity); }
                InvokePropertyChanged("Quarters");
            }

        }
        public int HalfDollars
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quanity = value - drawer.HalfDollars;
                if (quanity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quanity);
                }
                else { drawer.RemoveCoin(Coins.HalfDollar, -quanity); }
                InvokePropertyChanged("HalfDollars");
            }

        }

        public int  Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quanity = value - drawer.Dollars;
                if (quanity > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quanity);
                }
                else { drawer.RemoveCoin(Coins.Dollar, -quanity); }
                InvokePropertyChanged("Dollars");
            }

        }

        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quanity = value - drawer.Twos;
                if (quanity > 0)
                {
                    drawer.AddBill(Bills.Two, quanity);
                }
                else { drawer.RemoveBill(Bills.Two, -quanity); }
                InvokePropertyChanged("Twos");
            }

        }


        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quanity = value - drawer.Fives;
                if (quanity > 0)
                {
                    drawer.AddBill(Bills.Five, quanity);
                }
                else { drawer.RemoveBill(Bills.Five, -quanity); }
                InvokePropertyChanged("Fives");
            }

        }

        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quanity = value - drawer.Tens;
                if (quanity > 0)
                {
                    drawer.AddBill(Bills.Ten, quanity);
                }
                else { drawer.RemoveBill(Bills.Ten, -quanity); }
                InvokePropertyChanged("Tens");
            }

        }

        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quanity = value - drawer.Twenties;
                if (quanity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quanity);
                }
                else { drawer.RemoveBill(Bills.Twenty, -quanity); }
                InvokePropertyChanged("Twentys");
            }

        }
        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quanity = value - drawer.Fifties;
                if (quanity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quanity);
                }
                else { drawer.RemoveBill(Bills.Fifty, -quanity); }
                InvokePropertyChanged("Fifties");
            }

        }
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quanity = value - drawer.Hundreds;
                if (quanity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quanity);
                }
                else { drawer.RemoveBill(Bills.Hundred, -quanity); }
                InvokePropertyChanged("Hundreds");
            }

        }
        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
