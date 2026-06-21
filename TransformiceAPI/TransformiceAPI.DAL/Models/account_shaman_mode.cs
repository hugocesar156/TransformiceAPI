using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_shaman_mode")]
public partial class account_shaman_mode
{
    [Key]
    public int id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string color { get; set; } = null!;

    public int id_account { get; set; }

    public int id_shaman_mode { get; set; }

    [ForeignKey("id_account")]
    [InverseProperty("account_shaman_modes")]
    public virtual account id_accountNavigation { get; set; } = null!;

    [ForeignKey("id_shaman_mode")]
    [InverseProperty("account_shaman_modes")]
    public virtual shaman_mode id_shaman_modeNavigation { get; set; } = null!;
}
