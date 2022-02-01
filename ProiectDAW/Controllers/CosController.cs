using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Entities.DTOs;
using ProiectDAW.DAL.Repositories.CosRepository;

namespace ProiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosController : ControllerBase
    {
        private readonly ICosRepository _repository;

        public CosController(ICosRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("AddInCos")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddInCos([FromBody] Cos cos)
        {
            _repository.Create(cos);
            await _repository.SaveAsync();

            return Ok(new CosDTO(cos));
        }

        [HttpGet("GetCosByClientName/{name}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetCosByClientName(string name)
        {
            var produse = await _repository.GetCosByClientName(name);
            var cosToReturn = new List<CosDTO>();
            foreach (var produs in produse)
            {
                cosToReturn.Add(new CosDTO(produs));
            }
            return Ok(cosToReturn);
        }

        [HttpDelete("DeleteFromCos/{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteFromCos([FromRoute] int id)
        {
            var produs = await _repository.GetByIdAsync(id);
            _repository.Delete(produs);
            await _repository.SaveAsync();

            return Ok(produs);
        }

        [HttpPut("UpdateCos/{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> UpdateCos([FromBody] Cos updatedCos, [FromRoute] int id)
        {
            var produs = await _repository.GetByIdAsync(id);
            _repository.Delete(produs);
            _repository.Create(updatedCos);
            await _repository.SaveAsync();

            return Ok(updatedCos);
        }
    }
}
