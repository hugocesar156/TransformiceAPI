using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("level")]
public partial class level
{
    [Key]
    public int id { get; set; }

    public int number { get; set; }

    public int experience { get; set; }

    [InverseProperty("id_levelNavigation")]
    public virtual ICollection<account_level> account_levels { get; set; } = new List<account_level>();
}
