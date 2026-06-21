using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("user")]
[Index("email", Name = "UQ__user__AB6E616453F6A1E6", IsUnique = true)]
public partial class user
{
    [Key]
    public int id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string email { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string password { get; set; } = null!;

    [StringLength(24)]
    [Unicode(false)]
    public string salt { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime last_access { get; set; }

    [InverseProperty("id_userNavigation")]
    public virtual ICollection<account> accounts { get; set; } = new List<account>();
}
