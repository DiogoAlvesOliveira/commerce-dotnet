using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NTTData.Models;

namespace NTTData.Repositories;

public interface IClientRepository
{
    public Task<List<Client>> findAll();
    public Task<Client> findByEmail(string email);
}
