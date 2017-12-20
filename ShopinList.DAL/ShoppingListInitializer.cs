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
                Name = "Мясо"
            };

            var pig = new Item("Свинина");
            meatCategory.Items.Add(pig);

            meatCategory.Items.Add(new Item("Телятина"));
            var sousage = new Item("Сосиски");
            meatCategory.Items.Add(sousage);
            context.ItemCategorys.Add(meatCategory);




            var vegCategory = new ItemCategory()
            {
                Name = "Овощи"
            };

            vegCategory.Items.Add(new Item("Огурцы"));
            var tomato = new Item("Помидоры");

            vegCategory.Items.Add(tomato);

            vegCategory.Items.Add(new Item("Морковь"));

            context.ItemCategorys.Add(vegCategory);


            var fruitCategory = new ItemCategory()
            {
                Name = "Фрукты"
            };
            var apple = new Item("Яблука");
            fruitCategory.Items.Add(apple);
            fruitCategory.Items.Add(new Item("Мандарины"));
            fruitCategory.Items.Add(new Item("Бананы"));
            context.ItemCategorys.Add(fruitCategory);



            var drinkCategory = new ItemCategory()
            {
                Name = "Напитки"
            };

            drinkCategory.Items.Add(new Item("Минералка"));

            drinkCategory.Items.Add(new Item("Сок яблучный"));

            var beer = new Item("Пиво");
            drinkCategory.Items.Add(beer);
            context.ItemCategorys.Add(drinkCategory);
            #endregion

            #region Seed Test Users
            //Заполним базу, (по хорошему нужно сделать регистрацию и пароль обязательно хешировать.
            var user1 = new User()
            {
                UserName = "User1",
                HashPassword = "1111",
                LastLogin = DateTime.Now.AddDays(-5)
            };
            var shopList1U1 = new ShopList()
            {
                Name = "Пикник"
            };
            shopList1U1.ShopListItems.Add(
                new ShopListItem(apple, 5) { User = user1 });
            shopList1U1.ShopListItems.Add(new ShopListItem(beer, 2) { User = user1 });
            shopList1U1.ShopListItems.Add(new ShopListItem(tomato) { User = user1 });
            user1.ShopLists.Add(shopList1U1);

            var shopList2U1 = new ShopList()
            {
                Name = "Новый год"
            };
            shopList2U1.ShopListItems.Add(
                new ShopListItem(sousage) { User = user1 });

            shopList2U1.ShopListItems.Add(new ShopListItem(pig, 2.8) { User = user1 });
            user1.ShopLists.Add(shopList2U1);

            context.Users.Add(user1);


            var user2 = new User()
            {
                UserName = "User2",
                HashPassword = "2222",
                LastLogin = DateTime.Now.AddDays(-1)
            };
            var shopList2U2 = new ShopList()
            {
                Name = "User2 SHop List"
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