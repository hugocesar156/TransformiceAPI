using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("shaman_skill_type")]
public partial class shaman_skill_type
{
    [Key]
    public int id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    [InverseProperty("id_shaman_skill_typeNavigation")]
    public virtual ICollection<shaman_skill> shaman_skills { get; set; } = new List<shaman_skill>();
}
