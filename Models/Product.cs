using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NTTData.Models;

[Table("tb_products")]
public class Product
{
    public Product()
    {
        Orders = new Collection<Order>();
    }
    [Key]
    public int id { get; set; }
    [Required]
    [MaxLength(80)]
    public string? name { get; set; }
    [Required]
    [MaxLength(80)]
    public string? description { get; set; }
    [Required]
    [Column(TypeName="decimal(10,2)")]
    public decimal price { get; set; }
    [Required]
    public int stock { get; set; }

    public ICollection<Order>? Orders { get; set; }
}
