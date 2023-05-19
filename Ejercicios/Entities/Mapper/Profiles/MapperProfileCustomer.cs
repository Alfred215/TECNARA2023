using AutoMapper;
using Infraestructure.DTO.CustomerDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                .ForMember(dst => dst.EstadoDescription, options => options.MapFrom(src => GetDescriptio(src.Estado)))
                .ReverseMap();

            CreateMap<Customer, CustomerMiniDTO>()
                .ForMember(dst => dst.Name, options => options.MapFrom(src => src.Person.Name))
                .ForMember(dst => dst.Surname1, options => options.MapFrom(src => src.Person.Surname1))
                .ForMember(dst => dst.Surname2, options => options.MapFrom(src => src.Person.Surname2))
                .ForMember(dst => dst.Age, options => options.MapFrom(src => src.Person.Age))
                .ForMember(dst => dst.EstadoDescription, options => options.MapFrom(src => GetDescriptio(src.Estado)))
                .ReverseMap();

            CreateMap<Customer, CustomerPostDTO>()
                .ReverseMap();

            CreateMap<CustomerDTO, CustomerMiniDTO>()
                .ReverseMap();
        }

        public string GetDescriptio(EstadoType? value)
        {
            if(value == null)
            {
                return null;
            }
            var fieldInfo = value.GetType().GetField(value.ToString());

            var attribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if(attribute != null && attribute.Length > 0)
            {
                return attribute[0].Description;
            }
            return value.ToString();
        }
    }
}
