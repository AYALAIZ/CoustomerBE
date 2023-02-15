using Milgot.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories.Interfaces
{
    public interface IChildrenRepository
    {
        Task<List<Children>> GetAllAsync();

        Task<Children> GetByIdAsync(int id);

        Task<Children> AddAsync(Children c);

        Task<Children> UpdateAsync(Children child);

        Task DeleteAsync(int id);
    }
}
