using AutoMapper;
using Milgot.Common.DTOs;
using Milgot.Repositories.Entities;
using Milgot.Repositories.Interface;
using Milgot.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Services.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _detailsRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository detailsRepository, IMapper mapper)
        {
            _detailsRepository = detailsRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(UserDTO u)
        {
            await _detailsRepository.AddAsync(_mapper.Map<User>(u));
            return u;
        }

        public async Task DeleteAsync(int id)
        {
            await _detailsRepository.DeleteAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _detailsRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<UserDTO>(await _detailsRepository.GetByIdAsync(id));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO details)
        {
            return _mapper.Map<UserDTO>(await _detailsRepository.UpdateAsync(_mapper.Map<User>(details)));
        }

    }
}
