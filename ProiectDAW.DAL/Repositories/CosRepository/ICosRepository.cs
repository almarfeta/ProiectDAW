using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Repositories.GenericRepository;

namespace ProiectDAW.DAL.Repositories.CosRepository
{
    public interface ICosRepository : IGenericRepository<Cos>
    {
        Task<List<Cos>> GetCosByClientName(string name);
    }
}
