using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account_wallet")]
public partial class account_wallet
{
    [Key]
    public int id { get; set; }

    public int cheese { get; set; }

    public int strawberry { get; set; }

    public int id_account { get; set; }

    [ForeignKey("id_account")]
    [InverseProperty("account_wallets")]
    public virtual account id_accountNavigation { get; set; } = null!;
}
