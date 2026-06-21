using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("title")]
public partial class title
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [InverseProperty("id_titleNavigation")]
    public virtual ICollection<account_title> account_titles { get; set; } = new List<account_title>();

    [InverseProperty("id_titleNavigation")]
    public virtual ICollection<account> accounts { get; set; } = new List<account>();
}
