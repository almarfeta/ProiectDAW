using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectDAW.DAL;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Entities.DTOs;
using ProiectDAW.DAL.Repositories.ClientRepository;

namespace ProiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _repository;

        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetClientsWithAddress")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _repository.GetAllClientsWithAddress();
            var clientsToReturn = new List<ClientDTO>();
            foreach (var client in clients)
            {
                clientsToReturn.Add(new ClientDTO(client));
            }
            return Ok(clientsToReturn);
        }

        [HttpPost("AddClient")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddClient([FromBody] Client client)
        {
            _repository.Create(client);
            await _repository.SaveAsync();

            return Ok(new ClientDTO(client));
        }

        [HttpDelete("DeleteClient/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteClient([FromRoute] int id)
        {
            var client = await _repository.GetByIdAsync(id);
            _repository.Delete(client);
            await _repository.SaveAsync();

            return Ok(client);
        }

        [HttpPut("UpdateClient/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateClient([FromBody] Client updatedClient, [FromRoute] int id)
        {
            var client = await _repository.GetByIdAsync(id);
            _repository.Delete(client);
            _repository.Create(updatedClient);
            await _repository.SaveAsync();

            return Ok(updatedClient);
        }

        /*[HttpPut("UpdateClient")]
        public async Task<IActionResult> UpdateClient([FromBody] Client client)
        {
            _repository.Update(client);
            await _repository.SaveAsync();

            return Ok(client);
        }*/

    }
}
