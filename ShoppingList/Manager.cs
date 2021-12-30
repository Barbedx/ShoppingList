using BaseVM.Mediator;

using ShoppingList.BLL.Model;
using ShoppingList.DAL;
using ShoppingList.ViewModel;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace ShoppingList.BLL
{
    public sealed class Manager
    {

        private static readonly Lazy<Manager> _manager = new Lazy<Manager>(() => new Manager());
        public static Manager Instance => _manager.Value;

        internal void UpdateShopListItem(ShopListItem innerValue)
        {
            _ctx.Entry(innerValue).State = EntityState.Modified;
            _ctx.SaveChanges();
            Mediator.NotifyCollegues(PageNames.ShopListItemChanged, null);
        }
        private ShoppingListContext _ctx;
        private Manager()
        {
            if (_ctx == null)
                _ctx = new ShoppingListContext();
        }

        internal List<Item> GetAllItems()
        {
            return _ctx.Items.ToList();
        }

        private User _currentUser;

        public User CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
                Mediator.NotifyCollegues(PageNames.UserChanged, null);

            }
        }
        internal void AddItemToCurrentShopList(string itemName, double count)
        {
            try
            {

                Item item = _ctx.Items.FirstOrDefault(i => i.Name == itemName);
                if (item == null)
                {
                    item = new Item(itemName);
                    _ctx.Items.Add(item);

                }
                _ctx.ShopListItems.Add(new ShopListItem(item, count) { User = CurrentUser, ShopList = CurrentShopList.InnerValue });
                _ctx.SaveChanges();

                Mediator.NotifyCollegues(PageNames.ShopListItemChanged, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");


            }
        }

        private ShopListVM _currentShopList;
        public ShopListVM CurrentShopList
        {
            get => _currentShopList;
            set
            {
                _currentShopList = value;
                Mediator.NotifyCollegues(PageNames.ShopListChanged, null);
            }
        }
        public List<User> GetAllUsers()
        {
            try
            {
                return _ctx.Users.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
                //throw;
                return null;
            }
        }
        public List<ShopList> GetShopLists()
        {
            return CurrentUser.ShopLists.ToList();

        }


    }
}
