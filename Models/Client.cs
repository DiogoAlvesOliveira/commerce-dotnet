using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NTTData.Models;

[Table("tb_clients")]
public class Client
{
    public Client()
    {
        Addresses = new Collection<Address>();
        Orders = new Collection<Order>();
    }
    [Key]
    public int id { get; set; }
    [Required]
    [MaxLength(80)]
    public string? name { get; set; }
    [Required]
    [MaxLength(80)]
    public string? surname { get; set; }
    [Required]
    [MaxLength(40)]
    public string? email { get; set; }

    public ICollection<Address>? Addresses { get; set; }
    public ICollection<Order>? Orders { get; set; }

}
