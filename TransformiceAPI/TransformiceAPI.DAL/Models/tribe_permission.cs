using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("tribe_permission")]
public partial class tribe_permission
{
    [Key]
    public int id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    [InverseProperty("id_tribe_permissionNavigation")]
    public virtual ICollection<tribe_role_permission> tribe_role_permissions { get; set; } = new List<tribe_role_permission>();
}
