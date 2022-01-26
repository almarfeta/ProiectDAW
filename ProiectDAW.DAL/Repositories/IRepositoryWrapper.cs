using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectDAW.DAL.Repositories.SessionTokenRepository;
using ProiectDAW.DAL.Repositories.UserRepository;

namespace ProiectDAW.DAL.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ISessionTokenRepository SessionToken { get; }

        Task SaveAsync();
    }
}
