using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("shop_item_category")]
public partial class shop_item_category
{
    [Key]
    public int id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    [InverseProperty("id_shop_item_categoryNavigation")]
    public virtual ICollection<shop_item_type> shop_item_types { get; set; } = new List<shop_item_type>();
}
