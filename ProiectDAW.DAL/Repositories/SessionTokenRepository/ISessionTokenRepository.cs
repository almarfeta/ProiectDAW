using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.DAL.Entities;
using ProiectDAW.DAL.Repositories.GenericRepository;

namespace ProiectDAW.DAL.Repositories.SessionTokenRepository
{
    public interface ISessionTokenRepository : IGenericRepository<SessionToken>
    {
        Task<SessionToken> GetByJTI(string jti);
    }
}
