using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TransformiceAPI.DAL.Models;

[Table("account")]
[Index("name", Name = "UQ_account", IsUnique = true)]
public partial class account
{
    [Key]
    public int id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    public int id_gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime inscription_date { get; set; }

    public int id_title { get; set; }

    public int normal_mode_saves { get; set; }

    public int hard_mode_saves { get; set; }

    public int divine_mode_saves { get; set; }

    public int cheese_shaman { get; set; }

    public int fist_cheese { get; set; }

    public int cheese { get; set; }

    public int bootcamp { get; set; }

    public int id_user { get; set; }

    [InverseProperty("id_accountNavigation")]
    public virtual ICollection<account_level> account_levels { get; set; } = new List<account_level>();

    [InverseProperty("id_accountNavigation")]
    public virtual ICollection<account_shop_item> account_shop_items { get; set; } = new List<account_shop_item>();

    [InverseProperty("id_accountNavigation")]
    public virtual ICollection<account_shop_outfit> account_shop_outfits { get; set; } = new List<account_shop_outfit>();

    [InverseProperty("id_accountNavigation")]
    public virtual ICollection<account_title> account_titles { get; set; } = new List<account_title>();

    [InverseProperty("id_accountNavigation")]
    public virtual ICollection<account_wallet> account_wallets { get; set; } = new List<account_wallet>();

    [ForeignKey("id_gender")]
    [InverseProperty("accounts")]
    public virtual gender id_genderNavigation { get; set; } = null!;

    [ForeignKey("id_title")]
    [InverseProperty("accounts")]
    public virtual title id_titleNavigation { get; set; } = null!;

    [ForeignKey("id_user")]
    [InverseProperty("accounts")]
    public virtual user id_userNavigation { get; set; } = null!;
}
