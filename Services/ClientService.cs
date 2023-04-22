using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTTData.Data;
using NTTData.Models;
using NTTData.Repositories;

namespace NTTData.Services;

public class ClientService : IClientService
{

    private IClientRepository _clientRepository;

    public ClientService (IClientRepository clientRepository){
        _clientRepository = clientRepository;
    }

    public async Task<List<Client>> findAll()
    {
        return await _clientRepository.findAll();
    }
}
