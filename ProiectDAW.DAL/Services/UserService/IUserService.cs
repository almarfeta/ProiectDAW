using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectDAW.DAL.Entities.DTOs;

namespace ProiectDAW.DAL.Services.UserService
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterUserDTO dto);
        Task<string> LoginUser(LoginUserDTO dto);
    }
}
