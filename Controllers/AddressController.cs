using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTTData.Dtos;

namespace NTTData.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressController : ControllerBase
{
    [HttpGet]
    public Task<ActionResult<List<AddressDto>>> findByEmailAddress(string email){
        throw new NotImplementedException();
    }
}
