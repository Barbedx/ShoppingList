using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingList.BLL.Model
{
    public class Item
    {


        public Item()
        {
            ShopListItems = new HashSet<ShopListItem>();
        }

        public Item(string name)
        {
            Name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; private set; } 
        public int? CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public double Price { get; set;
        }
        [ForeignKey(nameof(CategoryId))]
        public virtual ItemCategory ItemCategory { get; set; }
        public virtual    ICollection<ShopListItem> ShopListItems { get; set; }


    }
}