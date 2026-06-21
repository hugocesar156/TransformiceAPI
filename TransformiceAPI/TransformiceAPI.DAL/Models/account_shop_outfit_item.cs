using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_shop_outfit_item")]
public partial class account_shop_outfit_item
{
    [Key]
    public int id { get; set; }

    public int id_account_shop_outfit { get; set; }

    public int id_account_shop_item { get; set; }

    [InverseProperty("id_account_shop_outfit_itemNavigation")]
    public virtual ICollection<account_shop_outfit_item_color> account_shop_outfit_item_colors { get; set; } = new List<account_shop_outfit_item_color>();

    [ForeignKey("id_account_shop_item")]
    [InverseProperty("account_shop_outfit_items")]
    public virtual account_shop_item id_account_shop_itemNavigation { get; set; } = null!;

    [ForeignKey("id_account_shop_outfit")]
    [InverseProperty("account_shop_outfit_items")]
    public virtual account_shop_outfit id_account_shop_outfitNavigation { get; set; } = null!;
}
