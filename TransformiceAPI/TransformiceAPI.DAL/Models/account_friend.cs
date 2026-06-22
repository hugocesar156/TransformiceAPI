using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_friend")]
public partial class account_friend
{
    [Key]
    public int id { get; set; }

    public int id_account { get; set; }

    public int id_friend { get; set; }

    [ForeignKey("id_account")]
    [InverseProperty("account_friendid_accountNavigations")]
    public virtual account id_accountNavigation { get; set; } = null!;

    [ForeignKey("id_friend")]
    [InverseProperty("account_friendid_friendNavigations")]
    public virtual account id_friendNavigation { get; set; } = null!;
}
