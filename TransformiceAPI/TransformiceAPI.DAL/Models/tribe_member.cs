using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("tribe_member")]
public partial class tribe_member
{
    [Key]
    public int id { get; set; }

    public int id_account { get; set; }

    public int id_tribe_role { get; set; }

    [ForeignKey("id_account")]
    [InverseProperty("tribe_members")]
    public virtual account id_accountNavigation { get; set; } = null!;

    [ForeignKey("id_tribe_role")]
    [InverseProperty("tribe_members")]
    public virtual tribe_role id_tribe_roleNavigation { get; set; } = null!;
}
