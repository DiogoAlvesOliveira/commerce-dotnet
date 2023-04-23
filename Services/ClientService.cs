using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTTData.Data;
using NTTData.Dtos;
using NTTData.Models;
using NTTData.Repositories;

namespace NTTData.Services;

public class ClientService : IClientService
{

    private IClientRepository _clientRepository;

    public ClientService (IClientRepository clientRepository){
        _clientRepository = clientRepository;
    }

    public async Task<List<ClientDto>> findAll()
    {
        var client = await _clientRepository.findAll();
        List<ClientDto> clientDtos = new List<ClientDto>();
        foreach (var cli in client){
            clientDtos.Add(toCleintDto(cli));
        }
        return clientDtos;
        
    }

    public async Task<ClientDto> findByEmail(string email)
    {
        var client = await _clientRepository.findByEmail(email);

        return toCleintDto(client);
    }

    public async Task<ClientDto> findById(int id)
    {
        var client = await _clientRepository.findById(id);

        return toCleintDto(client);
    }

    public async Task<Client> insert(Client client)
    {
        return await _clientRepository.insert(client);
    }

    public Client toClient(ClientDto clientDto)
    {
        return new Client(){
            id = clientDto.id,
            name = clientDto.name,
            surname = clientDto.surname,
            email = clientDto.email
        };
    }

    private ClientDto toCleintDto(Client client)
    {
        return new ClientDto(){
            id = client.id,
            name = client.name,
            surname = client.surname,
            email = client.email
        };
    }
}
