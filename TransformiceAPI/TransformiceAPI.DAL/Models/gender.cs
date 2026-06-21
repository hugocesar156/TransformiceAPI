using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("gender")]
public partial class gender
{
    [Key]
    public int id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    [InverseProperty("id_genderNavigation")]
    public virtual ICollection<account> accounts { get; set; } = new List<account>();
}
