using BaseVM;
using ShoppingList.BLL.Model;

namespace ShoppingList.ViewModel
{
    internal class ShopListCardVM : ViewModelBase
    {
        private ShopListVM _shopListVM;

        public ShopListCardVM(ShopListVM shopListVM)
        {
            this._shopListVM = shopListVM;
        }
    }
}