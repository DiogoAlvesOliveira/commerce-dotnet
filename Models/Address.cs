using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NTTData.Models;

[Table("tb_addresses")]
public class Address
{
    [Key]
    public int id { get; set; }
    [Required]
    [MaxLength(120)]
    public string? address { get; set; }
    [Required]
    [MaxLength(10)]
    public string? number { get; set; }
    [MaxLength(10)]
    public string? complement { get; set; }
    [Required]
    [MaxLength(40)]
    public string? neighborhood { get; set; }
    [Required]
    [MaxLength(40)]
    public string? city { get; set; }
    [Required]
    [MaxLength(20)]
    public string? state { get; set; }
    [Required]
    [MaxLength(20)]
    public string? country { get; set; }
    [Required]
    [MaxLength(10)]
    public string? zipCode { get; set; }
    public int ClientId { get; set; }
    public Client? Client { get; set; }
}
