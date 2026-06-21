using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("shop_item_type")]
public partial class shop_item_type
{
    [Key]
    public int id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    public int id_shop_item_category { get; set; }

    [ForeignKey("id_shop_item_category")]
    [InverseProperty("shop_item_types")]
    public virtual shop_item_category id_shop_item_categoryNavigation { get; set; } = null!;

    [InverseProperty("id_shop_item_typeNavigation")]
    public virtual ICollection<shop_item> shop_items { get; set; } = new List<shop_item>();
}
