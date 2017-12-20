using BaseVM;
using ShoppingList.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ShoppingList.UserControls
{
    /// <summary>
    /// Interaction logic for ShopListView.xaml
    /// </summary>
    public partial class ShopListView : UserControl//, INotifyPropertyChanged
    {
        public ShopListView()
        {
            InitializeComponent();
        }



        //public ShopListVM ShopListVM
        //{
        //    get { return (ShopListVM)GetValue(ShopListVMProperty); }
        //    set { SetValue(ShopListVMProperty, value);
        //        OnPropertyChanged();
        //    }
        //}

        //// Using a DependencyProperty as the backing store for ShopListVM.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ShopListVMProperty =
        //    DependencyProperty.Register("ShopListVM", typeof(ShopListVM), typeof(ShopListView), new PropertyMetadata(0));

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


        //private int _currentItemCount;

        //public int CurrentItemCount
        //{
        //    get { return ShopListVM.CurrentItemCount; }
        //    set
        //    {
        //        if (_currentItemCount != value)
        //        {
        //            _currentItemCount = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}



    }
}
