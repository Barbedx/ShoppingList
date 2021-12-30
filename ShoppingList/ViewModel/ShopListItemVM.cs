using BaseVM;

using ShoppingList.BLL;
using ShoppingList.BLL.Model;

namespace ShoppingList.ViewModel
{
    public class ShopListItemVM : ViewModelBase
    {
        public bool IsNew { get; set; } = false;

        public ShopListItem InnerValue { get; internal set; }
        public Item Item => InnerValue.Item;
        public bool IsChecked
        {
            get
            {
                return InnerValue.IsChecked;
            }
            set
            {
                if (InnerValue.IsChecked != value)
                {
                    InnerValue.IsChecked = value;
                    OnPropertyChanged();
                    if (!IsNew)
                        Manager.Instance.UpdateShopListItem(InnerValue);
                }
            }
        }

        

        public double Count
        {
            get { return InnerValue.Count; }
            set
            {
                if (InnerValue.Count != value)
                {
                    InnerValue.Count = value;
                    OnPropertyChanged(nameof(Count));
                }
            }
        }

    }
}