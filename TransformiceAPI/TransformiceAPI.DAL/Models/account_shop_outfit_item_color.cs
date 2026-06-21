using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_shop_outfit_item_color")]
public partial class account_shop_outfit_item_color
{
    [Key]
    public int id { get; set; }

    public int id_account_shop_outfit_item { get; set; }

    [ForeignKey("id_account_shop_outfit_item")]
    [InverseProperty("account_shop_outfit_item_colors")]
    public virtual account_shop_outfit_item id_account_shop_outfit_itemNavigation { get; set; } = null!;
}
