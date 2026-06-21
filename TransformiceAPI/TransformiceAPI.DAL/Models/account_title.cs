using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_title")]
public partial class account_title
{
    [Key]
    public int id { get; set; }

    public int id_title { get; set; }

    public int id_account { get; set; }

    [ForeignKey("id_account")]
    [InverseProperty("account_titles")]
    public virtual account id_accountNavigation { get; set; } = null!;

    [ForeignKey("id_title")]
    [InverseProperty("account_titles")]
    public virtual title id_titleNavigation { get; set; } = null!;
}
