using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTTData.Data;
using NTTData.Models;
using NTTData.Services;

namespace NTTData.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private IClientService _clientService;

    public ClientController (IClientService clientService){
        _clientService = clientService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Client>>> findAll(){
        var clients =await _clientService.findAll();
        if (clients is null){
            return BadRequest();
        }
        return clients;
    }
}
