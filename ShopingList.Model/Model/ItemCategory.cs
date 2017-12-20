using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.BLL.Model
{
    public class ItemCategory
    {
        public ItemCategory()
        {
            Items = new HashSet<Item>();
        }
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual  ICollection<Item> Items { get; set; }
    }
}