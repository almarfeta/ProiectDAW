using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Repositories.GenericRepository;

namespace ProiectDAW.DAL.Repositories.CosRepository
{
    public class CosRepository : GenericRepository<Cos>, ICosRepository
    {
        public CosRepository(AppDbContext context) : base(context) { }

        public async Task<List<Cos>> GetCosByClientName(string name)
        {
            return await _context
                .Cosuri
                .Include(x => x.Client)
                .Include(x => x.Produs)
                .Where(x => x.Client.Nume == name)
                .ToListAsync();
        }
    }
}
