using ShoppingList.BLL.Model;
using System.Data.Entity;

namespace ShoppingList.DAL
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext() : base("name=ShoppingList")
        {
            Database.SetInitializer(new ShoppingListInitializer());
        }

        public IDbSet<User> Users{ get; set; }
        public IDbSet<ShopList> ShopLists{ get; set; }
        public IDbSet<ShopListItem> ShopListItems { get; set; }
        public IDbSet<Item> Items { get; set; }
        public IDbSet<ItemCategory> ItemCategorys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(k => k.ID);
            modelBuilder.Entity<ShopList>().HasKey(k => new { k.ID, k.UserId });
            modelBuilder.Entity<ShopListItem>().HasKey(k => new { k.ShopListId, k.UserId, k.ItemId});
            modelBuilder.Entity<Item>().HasKey(k => k.ID);
            modelBuilder.Entity<ItemCategory>().HasKey(k => k.ID);


            modelBuilder.Entity<ShopListItem>()
                .HasRequired(r => r.ShopList)
                .WithMany(m => m.ShopListItems)
                .HasForeignKey(k => new { k.ShopListId, k.UserId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShopListItem>()
                .HasRequired(i => i.Item)
                .WithMany(m => m.ShopListItems)
                .HasForeignKey(k => k.ItemId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
