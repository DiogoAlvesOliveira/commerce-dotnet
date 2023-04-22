using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTTData.Dtos;

public class AddressDto
{
    public string? address { get; set; }
    public string? number { get; set; }
    public string? complement { get; set; }
    public string? neighborhood { get; set; }
    public string? city { get; set; }
    public string? uf { get; set; }
    public string? country { get; set; }
    public string? cep { get; set; }
}
