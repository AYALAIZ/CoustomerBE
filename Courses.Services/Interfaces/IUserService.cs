﻿using AutoMapper;
using Milgot.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Services.Interface
{
    public interface IUserService
    {

        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(int id);

        Task<UserDTO> AddAsync(UserDTO u);

        Task<UserDTO> UpdateAsync(UserDTO user);

        Task DeleteAsync(int id);
    }
}
