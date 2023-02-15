using Milgot.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Services.Interfaces
{
    public interface IChildrenService
    {
        Task<List<ChildrenDTO>> GetAllAsync();

        Task<ChildrenDTO> GetByIdAsync(int id);

        Task<ChildrenDTO> AddAsync(ChildrenDTO c);

        Task<ChildrenDTO> UpdateAsync(ChildrenDTO claim);

        Task DeleteAsync(int id);
    }
}
