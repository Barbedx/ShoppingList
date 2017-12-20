using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingList.BLL.Model
{
    public class User
    {
        public User()
        {
            ShopLists = new HashSet<ShopList>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        public string HashPassword { get; set; }

        public DateTime LastLogin { get; set; }

        public virtual  ICollection<ShopList> ShopLists { get; set; }
    }
}
