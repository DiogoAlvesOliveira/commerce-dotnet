using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTTData.Models;

[Table("tb_orders")]
public class Order
{
    public Order()
    {
        Products = new Collection<Product>();
    }
    [Key]
    public int id { get; set; }
    public DateTime instant { get; set; }

    public int ClientId { get; set; }
    public Client? Client { get; set; }

    public ICollection<Product>? Products { get; set; }
}
