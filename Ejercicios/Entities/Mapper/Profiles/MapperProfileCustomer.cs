using AutoMapper;
using Infraestructure.DTO.CustomerDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileCustomer : Profile
    {
        public MapperProfileCustomer()
        {
            CreateMap<Customer, CustomerDTO>()
                .ForMember(dst => dst.Name, options => options.MapFrom(src => src.Person.Name))
                .ForMember(dst => dst.Surname1, options => options.MapFrom(src => src.Person.Surname1))
                .ForMember(dst => dst.Surname2, options => options.MapFrom(src => src.Person.Surname2))
                .ForMember(dst => dst.Age, options => options.MapFrom(src => src.Person.Age))
                .ReverseMap();

            CreateMap<Customer, CustomerMiniDTO>()
                .ForMember(dst => dst.Name, options => options.MapFrom(src => src.Person.Name))
                .ForMember(dst => dst.Surname1, options => options.MapFrom(src => src.Person.Surname1))
                .ForMember(dst => dst.Surname2, options => options.MapFrom(src => src.Person.Surname2))
                .ForMember(dst => dst.Age, options => options.MapFrom(src => src.Person.Age))
                .ReverseMap();

            CreateMap<Customer, CustomerPostDTO>()
                .ReverseMap();

            CreateMap<CustomerDTO, CustomerMiniDTO>()
                .ReverseMap();
        }
    }
}
