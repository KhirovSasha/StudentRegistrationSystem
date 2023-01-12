using AutoMapper;
using BusinessLogic.Dto.AuthDto;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.MapperProfilers
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile() 
        {
            CreateMap<RegisterDto, User>()
                .ForMember(user => user.FullName, opt => opt.MapFrom(user => $"{user.FirstName} {user.LastName}"));
        }
    }
}
