using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Repositories.GenericRepository;

namespace ProiectDAW.DAL.Repositories.ProdusRepository
{
    public interface IProdusRepository : IGenericRepository<Produs>
    {
        Task<Produs> GetByName(string name);
        Task<List<Produs>> GetAllProductsOrderByFurnizor();
    }
}
