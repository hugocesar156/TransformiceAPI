using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_shaman_skill")]
public partial class account_shaman_skill
{
    [Key]
    public int id { get; set; }

    public int multiplied { get; set; }

    public int id_shaman_skill { get; set; }

    public int id_account { get; set; }

    [ForeignKey("id_account")]
    [InverseProperty("account_shaman_skills")]
    public virtual account id_accountNavigation { get; set; } = null!;

    [ForeignKey("id_shaman_skill")]
    [InverseProperty("account_shaman_skills")]
    public virtual shaman_skill id_shaman_skillNavigation { get; set; } = null!;
}
