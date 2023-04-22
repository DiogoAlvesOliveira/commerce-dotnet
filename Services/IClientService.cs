using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NTTData.Models;

namespace NTTData.Services;

public interface IClientService
{
    public Task<List<Client>> findAll();
}
