using ShoppingList.BLL.Model;
using BaseVM;
using System.Windows.Input;
using BaseVM.Mediator;
using ShoppingList.BLL;

namespace ShoppingList.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {
        public MainWindowVM()
        {
            CurrentPageVM = new ChangeUserVM();
            Mediator.Register(PageNames.UserChanged, OnUserChanged);
            Mediator.Register(PageNames.ShopListChanged, OnShopListChanged);
 
            Mediator.Register(PageNames.ShopListItemChanged, (args) => OnPropertyChanged(nameof(CurrentShopList)));
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
            //Manager.Instance.CurrentShopList = null;
        }


        public ShopListVM CurrentShopList => Manager.Instance.CurrentShopList;
        public User CurrentUser => Manager.Instance.CurrentUser;

        public bool UserSelected => CurrentUser != null;
        public bool ShopListSelected => CurrentShopList != null;



        private ViewModelBase _currentPageVM;

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
