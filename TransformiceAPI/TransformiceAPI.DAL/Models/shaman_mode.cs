using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("shaman_mode")]
public partial class shaman_mode
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    [InverseProperty("id_shaman_modeNavigation")]
    public virtual ICollection<account_shaman_mode> account_shaman_modes { get; set; } = new List<account_shaman_mode>();
}
