using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTTData.Data;
using NTTData.Models;
using NTTData.Services;
using NTTData.Dtos;
using NTTData.Controllers.Api;

namespace NTTData.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ClientApi
{
    private IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    public override async Task<ActionResult<List<ClientDto>>> findAll()
    {
        var clients = await _clientService.findAll();
        if (clients is null)
        {
            return BadRequest();
        }
        return clients;
    }

    public override async Task<ActionResult<ClientDto>> findByEmail(string email)
    {
        var client = await _clientService.findByEmail(email);
        if (client is null)
        {
            return NotFound();
        }
        return client;
    }

    public override async Task<ActionResult<ClientDto>> findById(int id)
    {
        var client = await _clientService.findById(id);
        if (client is null){
            return NotFound();
        }
        return client;
    }
    public override async Task<ActionResult> insertClient(ClientDto clientDto)
    {
        Client client = _clientService.toClient(clientDto);
        client = await _clientService.insert(client);
        return new CreatedAtRouteResult("GetClient", new { id = client.id }, client);
    }

    public override Task<ActionResult> updateClient(string email, ClientDto clientDto)
    {
        throw new NotImplementedException();
    }
    public override Task<ActionResult> deleteClient(string email)
    {
        throw new NotImplementedException();
    }
}
