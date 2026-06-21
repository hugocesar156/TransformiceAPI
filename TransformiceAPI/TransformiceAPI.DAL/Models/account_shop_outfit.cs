using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_shop_outfit")]
public partial class account_shop_outfit
{
    [Key]
    public int id { get; set; }

    public int id_account { get; set; }

    [InverseProperty("id_account_shop_outfitNavigation")]
    public virtual ICollection<account_shop_outfit_item> account_shop_outfit_items { get; set; } = new List<account_shop_outfit_item>();

    [ForeignKey("id_account")]
    [InverseProperty("account_shop_outfits")]
    public virtual account id_accountNavigation { get; set; } = null!;
}
