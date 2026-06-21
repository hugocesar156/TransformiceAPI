using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("tribe")]
public partial class tribe
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [InverseProperty("id_tribeNavigation")]
    public virtual ICollection<tribe_role> tribe_roles { get; set; } = new List<tribe_role>();
}
