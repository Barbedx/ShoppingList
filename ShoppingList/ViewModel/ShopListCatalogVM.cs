using BaseVM;
using ShoppingList.BLL.Model;
using System.Collections.Generic;
using System.Windows.Input;
using System;
using BaseVM.Mediator;
using ShoppingList.BLL;
using System.Linq;

namespace ShoppingList.ViewModel
{
    public  class ShopListCatalogVM : ViewModelBase
    {
        private List<ShopListVM> _availableShopList;

        public List<ShopListVM> AvailableShopList => _availableShopList ?? (_availableShopList= Manager.Instance.GetShopLists().Select(x => new ShopListVM(){InnerValue = x}).ToList());


        private ShopListVM _selectedShopList;

        public ShopListVM SelectedShopList
        {
            get { return _selectedShopList; }
            set
            {
                if (_selectedShopList != value)
                {
                    _selectedShopList = value;
                    OnPropertyChanged(nameof(SelectedShopList));
                }
            }
        }

        private void ChangeShopList()
        {
            Manager.Instance.CurrentShopList = SelectedShopList;
        }

        public ICommand ChangeShopListCommand
        {
            get { return Commands.GetOrCreateCommand(() => ChangeShopListCommand, ChangeShopList, CanChangeShopList); }
        }

        private bool CanChangeShopList()
        {
           return  _selectedShopList != null;
        }

        private void AddShopList()
        {
            Mediator.NotifyCollegues(PageNames.NewShopList,null);
        }

        public ICommand AddShopListCommand
        {
            get { return Commands.GetOrCreateCommand(() => AddShopListCommand, AddShopList); }
        }

    }
}