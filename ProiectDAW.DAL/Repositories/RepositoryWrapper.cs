using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectDAW.DAL.Repositories.SessionTokenRepository;
using ProiectDAW.DAL.Repositories.UserRepository;

namespace ProiectDAW.DAL.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _context;
        private IUserRepository _user;
        private ISessionTokenRepository _sessionToken;

        public RepositoryWrapper(AppDbContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository.UserRepository(_context);
                return _user;
            }
        }

        public ISessionTokenRepository SessionToken
        {
            get
            {
                if (_sessionToken == null)
                {
                    _sessionToken = new SessionTokenRepository.SessionTokenRepository(_context);
                }

                return _sessionToken;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
