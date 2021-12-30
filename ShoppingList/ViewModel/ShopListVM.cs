using BaseVM;
using System.Collections.Generic;
using System.Linq;
using ShoppingList.BLL.Model;
using System.Windows.Input;
using ShoppingList.BLL;

namespace ShoppingList.ViewModel
{
    public class ShopListVM : ViewModelBase //: EditableDataVM<ShopList>
    {
        public ShopListVM() { }
        private ShopList _innerValue;

        public ShopList InnerValue
        {
            get { return _innerValue; }
            set { _innerValue = value; }
        }

        public List<ShopListItemVM> Items => InnerValue.ShopListItems.Select(x => new ShopListItemVM() { InnerValue = x }).ToList();
        public int ItemCount => InnerValue.ShopListItems.Count();
        public int CurrentItemCount => InnerValue.ShopListItems.Where(x => x.IsChecked).Count();

        public string Name => InnerValue.Name;


        public List<Item> AllItems => Manager.Instance.GetAllItems();

        private string _newItemName;

        public string NewItemName
        {
            get { return _newItemName; }
            set
            {
                if (_newItemName != value)
                {
                    _newItemName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Error));
                }
            }
        }

        private double _count;

        public double Count
        {
            get { return _count; }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Error));
                }
            }
        }

        public void AddItem()
        {

            Manager.Instance.AddItemToCurrentShopList(NewItemName, Count);
            OnPropertyChanged(nameof(Items));
        }

        public ICommand AddItemCommand
        {
            get { return Commands.GetOrCreateCommand(() => AddItemCommand, AddItem, CanAddItem); }
        }

        private bool CanAddItem()
        {
            return !HasErrors;
        }

        public override string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(NewItemName) when string.IsNullOrWhiteSpace(Name):
                        return "Set Name!";
                    case nameof(NewItemName) when Items.Any(x => x.Item.Name == NewItemName):
                        return "This item already exists in list";
                    case nameof(Count) when Count <= 0:
                        return "Quantity must be great than 0";
                    default:
                        return string.Empty;
                }
            }
        }
        public bool HasErrors => !string.IsNullOrEmpty(Error);
        public override string Error
        {
            get
            {
                string[] columns = new string[]
                {
                    this[nameof(NewItemName)],
                    this[nameof(Count)]
                };
                return columns.FirstOrDefault(x => !string.IsNullOrEmpty(x))??string.Empty;
            }
        }
    }
}
