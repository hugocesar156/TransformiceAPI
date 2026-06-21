using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("shop_item")]
public partial class shop_item
{
    [Key]
    public int id { get; set; }

    public int cheese_price { get; set; }

    public int? strawberry_price { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string icon { get; set; } = null!;

    public int id_shop_item_type { get; set; }

    [InverseProperty("id_shop_itemNavigation")]
    public virtual ICollection<account_shop_item> account_shop_items { get; set; } = new List<account_shop_item>();

    [ForeignKey("id_shop_item_type")]
    [InverseProperty("shop_items")]
    public virtual shop_item_type id_shop_item_typeNavigation { get; set; } = null!;

    [InverseProperty("id_shop_itemNavigation")]
    public virtual ICollection<shop_item_color> shop_item_colors { get; set; } = new List<shop_item_color>();
}
