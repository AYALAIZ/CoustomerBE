using Milgot.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();

        Task<User> GetByIdAsync(int id);

        Task<User> AddAsync(User u);

        Task<User> UpdateAsync(User details);

        Task DeleteAsync(int id);
    }
}
