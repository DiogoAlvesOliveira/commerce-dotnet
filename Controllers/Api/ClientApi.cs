using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTTData.Dtos;

namespace NTTData.Controllers.Api;

[Produces("application/json")]
[ApiController]
[Route("api/[controller]")]
public abstract class ClientApi : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(200)]
    public abstract Task<ActionResult<List<ClientDto>>> findAll();

    [HttpGet("{email}")]
    [ProducesResponseType(200)]
    public abstract Task<ActionResult<ClientDto>> findByEmail(string email);

    [HttpGet("{id:int}", Name="GetClient")]
    [ProducesResponseType(200)]
    public abstract Task<ActionResult<ClientDto>> findById(int id);

    [HttpPost]
    [ProducesResponseType(201)]
    public abstract Task<ActionResult> insertClient(ClientDto clientDto);

    [HttpPut]
    [ProducesResponseType(204)]
    public abstract Task<ActionResult> updateClient(string email, ClientDto clientDto);

    [HttpDelete]
    [ProducesResponseType(204)]
    public abstract Task<ActionResult> deleteClient(string email);
}
