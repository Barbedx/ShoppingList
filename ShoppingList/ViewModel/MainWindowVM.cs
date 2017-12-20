using ShoppingList.BLL.Model;
using ShoppingList.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using BaseVM;
using System.Windows.Input;
using BaseVM.Mediator;
using System;
using ShoppingList.BLL;

namespace ShoppingList.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {

    


        public MainWindowVM()
        {
            //CurrentPageVM = new ShopListVM();
            CurrentPageVM = new ChangeUserVM();
            Mediator.Register(PageNames.UserChanged, OnUserChanged);
            Mediator.Register(PageNames.ShopListChanged, OnShopListChanged);
            Mediator.Register(PageNames.NewShopList, OpenNewShopList);
            Mediator.Register(PageNames.ShopListItemChanged, ((args) => OnPropertyChanged(nameof(CurrentShopList))));
        }

        private void OpenNewShopList(object obj)
        {
            //CurrentPageVM = new ShopListCardVM(new ShopListVM(new  ShopList() { User = CurrentUser }));
        }

        private void OnShopListChanged(object obj)
        {
            OnPropertyChanged(nameof(CurrentShopList));
            OnPropertyChanged(nameof(ShopListSelected));
            CurrentPageVM = CurrentShopList;
        }

        private void OnUserChanged(object obj)
        {
            OnPropertyChanged(nameof(CurrentUser));
            OnPropertyChanged(nameof(UserSelected));
            OnPropertyChanged(nameof(ShopListSelected));
            CurrentPageVM = new ShopListCatalogVM();
        }


        public ShopListVM CurrentShopList => Manager.Instance.CurrentShopList;
        public User CurrentUser => Manager.Instance.CurrentUser;

        public bool UserSelected => CurrentUser != null;
        public bool ShopListSelected=> CurrentShopList != null;

         

        private  ViewModelBase _currentPageVM;

        public ViewModelBase CurrentPageVM
        {
            get { return _currentPageVM; }
            set
            {
                if (_currentPageVM != value)
                {
                    _currentPageVM = value;
                    OnPropertyChanged(nameof(CurrentPageVM));
                }
            }
        }


        private void ChangeUser()
        {
            Manager.Instance.CurrentUser = null;
            OnPropertyChanged(nameof(UserSelected));
            CurrentPageVM = new ChangeUserVM();
        }

        public ICommand LogOutCommand
        {
            get { return Commands.GetOrCreateCommand(() => LogOutCommand, ChangeUser); }
        }

        private void ChangeShopList()
        {
            CurrentPageVM = new ShopListCatalogVM();
        }

        public ICommand ChangeShopListCommand
        {
            get { return Commands.GetOrCreateCommand(() => ChangeShopListCommand, ChangeShopList); }
        }



    }
}
