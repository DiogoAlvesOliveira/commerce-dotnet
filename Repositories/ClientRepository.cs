using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTTData.Data;
using NTTData.Models;

namespace NTTData.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly DbSet<Client>? _client;

    public ClientRepository(AppDbContext client)
    {
        _client = client.Clients;
    }

    public async Task<List<Client>> findAll()
    {
        return await _client.AsNoTracking().ToListAsync();
    }
}
