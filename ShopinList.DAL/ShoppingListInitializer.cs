using ShoppingList.BLL.Model;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ShoppingList.DAL
{
    internal class ShoppingListInitializer : DropCreateDatabaseIfModelChanges<ShoppingListContext>
    {

        protected override void Seed(ShoppingListContext context)
        {

            #region Seed Item Categorys
            var meatCategory = new ItemCategory()
            {
                Name = "Meat"
            };

            var pig = new Item("Pork");
            meatCategory.Items.Add(pig);

            meatCategory.Items.Add(new Item("Veal"));
            var sousage = new Item("Sousage");
            meatCategory.Items.Add(sousage);
            context.ItemCategorys.Add(meatCategory);




            var vegCategory = new ItemCategory()
            {
                Name = "Wegetables"
            };

            vegCategory.Items.Add(new Item("Onion"));
            var tomato = new Item("Tomato");
            vegCategory.Items.Add(tomato);
            vegCategory.Items.Add(new Item("Carrot"));
            context.ItemCategorys.Add(vegCategory);


            var fruitCategory = new ItemCategory()
            {
                Name = "Fruits"
            };
            var apple = new Item("Apple");
            fruitCategory.Items.Add(apple);
            fruitCategory.Items.Add(new Item("Tangerines"));
            fruitCategory.Items.Add(new Item("Bananas"));
            context.ItemCategorys.Add(fruitCategory);



            var drinkCategory = new ItemCategory()
            {
                Name = "Drinks"
            };

            var beer = new Item("Beer");
            drinkCategory.Items.Add(new Item("Beer"));
            drinkCategory.Items.Add(new Item("Apple juice"));
            drinkCategory.Items.Add(new Item("Orange juice"));
             
            context.ItemCategorys.Add(drinkCategory);
            #endregion

            #region Seed Test Users
            // Fill in the base, (for good reason, you need to do the registration and the password must be hashed.
            var user1 = new User()
            {
                UserName = "Furkan",
                HashPassword = "1111",
                LastLogin = DateTime.Now.AddDays(-5)
            };
            var shopList1U1 = new ShopList()
            {
                Name = "ski trip"
            };
            shopList1U1.ShopListItems.Add(
                new ShopListItem(apple, 5) { User = user1 });
            shopList1U1.ShopListItems.Add(new ShopListItem(beer, 2) { User = user1 });
            shopList1U1.ShopListItems.Add(new ShopListItem(tomato) { User = user1 });
            user1.ShopLists.Add(shopList1U1);

            var shopList2U1 = new ShopList()
            {
                Name = "New Year party"
            };
            shopList2U1.ShopListItems.Add(
                new ShopListItem(sousage) { User = user1 });

            shopList2U1.ShopListItems.Add(new ShopListItem(pig, 2.8) { User = user1 });
            user1.ShopLists.Add(shopList2U1);

            context.Users.Add(user1);


            var user2 = new User()
            {
                UserName = "Grandpa",
                HashPassword = "2222",
                LastLogin = DateTime.Now.AddDays(-1)
            };
            var shopList2U2 = new ShopList()
            {
                Name = "gifts for grandchildren"
            };
            shopList2U2.ShopListItems.Add(new ShopListItem(sousage, 7) { User = user2 });
            shopList2U2.ShopListItems.Add(new ShopListItem(tomato, 10) { User = user2 });

            user2.ShopLists.Add(shopList2U2);
            context.Users.Add(user2);
            #endregion
             
            base.Seed(context);
        }
    }
}