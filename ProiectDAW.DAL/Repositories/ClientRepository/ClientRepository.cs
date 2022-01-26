using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Repositories.GenericRepository;

namespace ProiectDAW.DAL.Repositories.ClientRepository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(AppDbContext context) : base(context) { }
        public async Task<List<Client>> GetAllClientsWithAddress()
        {
            return await _context.Clienti.Include(a => a.Adresa).ToListAsync();
        }

        public async Task<Client> GetByName(string name)
        {
            return await _context.Clienti.Where(a => a.Nume.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
