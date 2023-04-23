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
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext client, AppDbContext context)
    {
        _client = client.Clients;
        _context = context;
    }

    public async Task<List<Client>> findAll()
    {
        return await _client.AsNoTracking().ToListAsync();
    }

    public async Task<Client> findByEmail(string email)
    {
        return await _client.AsNoTracking().Where(c => c.email == email).FirstAsync();
    }

    public async Task<Client> findById(int id)
    {
        return await _client.AsNoTracking().Where(c => c.id == id).FirstAsync();
    }

    public async Task<Client> insert(Client client)
    {
        _client.Add(client);
        await _context.SaveChangesAsync();
        return client;
    }
}
