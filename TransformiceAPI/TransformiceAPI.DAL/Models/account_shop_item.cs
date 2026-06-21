using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_shop_item")]
public partial class account_shop_item
{
    [Key]
    public int id { get; set; }

    public bool in_use { get; set; }

    public bool customized { get; set; }

    public bool favorite { get; set; }

    public int id_account { get; set; }

    public int id_shop_item { get; set; }

    [InverseProperty("id_account_shop_itemNavigation")]
    public virtual ICollection<account_shop_item_color> account_shop_item_colors { get; set; } = new List<account_shop_item_color>();

    [InverseProperty("id_account_shop_itemNavigation")]
    public virtual ICollection<account_shop_outfit_item> account_shop_outfit_items { get; set; } = new List<account_shop_outfit_item>();

    [ForeignKey("id_account")]
    [InverseProperty("account_shop_items")]
    public virtual account id_accountNavigation { get; set; } = null!;

    [ForeignKey("id_shop_item")]
    [InverseProperty("account_shop_items")]
    public virtual shop_item id_shop_itemNavigation { get; set; } = null!;
}
