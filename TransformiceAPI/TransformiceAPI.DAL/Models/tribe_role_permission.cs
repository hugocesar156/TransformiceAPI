using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("tribe_role_permission")]
public partial class tribe_role_permission
{
    [Key]
    public int id { get; set; }

    public int id_tribe_role { get; set; }

    public int id_tribe_permission { get; set; }

    [ForeignKey("id_tribe_permission")]
    [InverseProperty("tribe_role_permissions")]
    public virtual tribe_permission id_tribe_permissionNavigation { get; set; } = null!;

    [ForeignKey("id_tribe_role")]
    [InverseProperty("tribe_role_permissions")]
    public virtual tribe_role id_tribe_roleNavigation { get; set; } = null!;
}
