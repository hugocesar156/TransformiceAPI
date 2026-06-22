using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("shaman_skill")]
public partial class shaman_skill
{
    [Key]
    public int id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    public int? skill_value { get; set; }

    public int multiplied { get; set; }

    public int tree_level { get; set; }

    public int tree_order { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string icon { get; set; } = null!;

    public int id_shaman_skill_type { get; set; }

    [InverseProperty("id_shaman_skillNavigation")]
    public virtual ICollection<account_shaman_skill> account_shaman_skills { get; set; } = new List<account_shaman_skill>();

    [ForeignKey("id_shaman_skill_type")]
    [InverseProperty("shaman_skills")]
    public virtual shaman_skill_type id_shaman_skill_typeNavigation { get; set; } = null!;
}
