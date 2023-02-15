using AutoMapper;
using Milgot.Common.DTOs;
using Milgot.Repositories.Entities;
using Milgot.Repositories.Interfaces;
using Milgot.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Services.Services
{
    public class ChildrenService:IChildrenService
    {
        private readonly IChildrenRepository _children;
        private readonly IMapper _mapper;

        public ChildrenService(IChildrenRepository claim, IMapper mapper)
        {
            _children = claim;
            _mapper = mapper;
        }

        public async Task<ChildrenDTO> AddAsync( ChildrenDTO c)
        {
            //await _children.AddAsync(name,date,tz,idParent);
            //return new ChildrenDTO { Name = name, BirthDate = date, Tz = tz, parentId = idParent };

            return _mapper.Map<ChildrenDTO>(await _children.AddAsync(_mapper.Map<Children>(c)));
        }

        public async Task DeleteAsync(int id)
        {
            await _children.DeleteAsync(id);
        }

        public async Task<List<ChildrenDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildrenDTO>>(await _children.GetAllAsync());
        }

  

        public async Task<ChildrenDTO> GetByIdAsync(int id)
        {
            return _mapper.Map< ChildrenDTO> (await _children.GetAllAsync());
        }

        public async Task<ChildrenDTO> UpdateAsync(ChildrenDTO children)
        {

            return _mapper.Map<ChildrenDTO>(await _children.UpdateAsync(_mapper.Map<Children>(children)));
        }
    }
}
