using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NTTData.Dtos;
using NTTData.Models;

namespace NTTData.Services;

public interface IClientService
{
    public Task<List<ClientDto>> findAll();
    public Task<ClientDto> findByEmail(string email);
    public Task<ClientDto> findById(int id);
    public Task<Client> insert(Client client);
    public Client toClient(ClientDto clientDto);
}
