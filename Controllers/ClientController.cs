using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTTData.Data;
using NTTData.Models;

namespace NTTData.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly AppDbContext _context;

    public ClientController (AppDbContext context){
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Client>> findAll(){
        var clients = _context.Clients.ToList();
        if (clients is null){
            return BadRequest();
        }
        return clients;
    }
}
