using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Entities.DTOs;
using ProiectDAW.DAL.Repositories.ProdusRepository;

namespace ProiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly IProdusRepository _repository;

        public ProdusController(IProdusRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("AddProdus")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddProdus([FromBody] Produs produs)
        {
            _repository.Create(produs);
            await _repository.SaveAsync();

            return Ok(new ProdusDTO(produs));
        }

        [HttpGet("GetProdusOrderByFurnizor")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllProducts()
        {
            var produse = await _repository.GetAllProductsOrderByFurnizor();
            var produseToReturn = new List<ProdusDTO>();
            foreach (var produs in produse)
            {
                produseToReturn.Add(new ProdusDTO(produs));
            }
            return Ok(produseToReturn);
        }

        [HttpDelete("DeleteProdus/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProdus([FromRoute] int id)
        {
            var produs = await _repository.GetByIdAsync(id);
            _repository.Delete(produs);
            await _repository.SaveAsync();

            return Ok(produs);
        }

        [HttpPut("UpdateProdus/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateProdus([FromBody] Produs updatedProduct, [FromRoute] int id)
        {
            var produs = await _repository.GetByIdAsync(id);
            _repository.Delete(produs);
            _repository.Create(updatedProduct);
            await _repository.SaveAsync();

            return Ok(updatedProduct);
        }
    }
}
