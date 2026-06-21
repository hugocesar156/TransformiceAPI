using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("tribe_role")]
public partial class tribe_role
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    public int id_tribe { get; set; }

    [ForeignKey("id_tribe")]
    [InverseProperty("tribe_roles")]
    public virtual tribe id_tribeNavigation { get; set; } = null!;

    [InverseProperty("id_tribe_roleNavigation")]
    public virtual ICollection<tribe_member> tribe_members { get; set; } = new List<tribe_member>();

    [InverseProperty("id_tribe_roleNavigation")]
    public virtual ICollection<tribe_role_permission> tribe_role_permissions { get; set; } = new List<tribe_role_permission>();
}
