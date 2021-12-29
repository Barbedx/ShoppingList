using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingList.BLL.Model
{
    public class ShopListItem
    {

        public ShopListItem() { }
        public ShopListItem(Item item, double count = 1)
        {
            Item = item;
            Count = count;
        }

        [Key, Column(Order = 0)]
        [ForeignKey(nameof(ShopList))]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShopListId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(ShopList))]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }



        [Key, Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }

        public bool IsChecked { get; set; }

        public double Count { get; set; }

        [ForeignKey(nameof(UserId))]
        public  virtual User User { get; set; }


        public   virtual ShopList ShopList { get; set; }

        [ForeignKey(nameof(ItemId))]
        public   virtual Item Item { get; set; }


    }
}