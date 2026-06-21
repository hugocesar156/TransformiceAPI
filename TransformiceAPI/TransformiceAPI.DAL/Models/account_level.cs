using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_level")]
public partial class account_level
{
    [Key]
    public int id { get; set; }

    public int id_level { get; set; }

    public int experience { get; set; }

    public int id_account { get; set; }

    [ForeignKey("id_account")]
    [InverseProperty("account_levels")]
    public virtual account id_accountNavigation { get; set; } = null!;

    [ForeignKey("id_level")]
    [InverseProperty("account_levels")]
    public virtual level id_levelNavigation { get; set; } = null!;
}
