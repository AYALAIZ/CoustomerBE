using AutoMapper;
using Milgot.Common.DTOs;
using Milgot.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Children, ChildrenDTO>().ReverseMap();
        }
    }
}
