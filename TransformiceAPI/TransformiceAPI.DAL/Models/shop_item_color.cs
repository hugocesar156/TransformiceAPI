using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("shop_item_color")]
public partial class shop_item_color
{
    [Key]
    public int id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string color { get; set; } = null!;

    public int id_shop_item { get; set; }

    [ForeignKey("id_shop_item")]
    [InverseProperty("shop_item_colors")]
    public virtual shop_item id_shop_itemNavigation { get; set; } = null!;
}
