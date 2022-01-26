using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Repositories.GenericRepository;

namespace ProiectDAW.DAL.Repositories.ProdusRepository
{
    public class ProdusRepository : GenericRepository<Produs>, IProdusRepository
    {
        public ProdusRepository(AppDbContext context) : base(context) { }
        public async Task<List<Produs>> GetAllProductsOrderByFurnizor()
        {
            return await _context
                .Produse
                .Include(x => x.Furnizor)
                .OrderBy(x => x.Furnizor)
                .ToListAsync();
        }

        public async Task<Produs> GetByName(string name)
        {
            return await _context.Produse.Where(a => a.Nume.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
