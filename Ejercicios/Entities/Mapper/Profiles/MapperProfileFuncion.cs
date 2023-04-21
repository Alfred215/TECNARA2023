using AutoMapper;
using Infraestructure.DTO.FuncionDTOs;
using Infraestructure.DTO.PersonDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileFuncion : Profile
    {
        public MapperProfileFuncion()
        {
            CreateMap<Funcion, FuncionDTO>()
                .ForMember(dst => dst.AreaNombre, options => options.MapFrom(src => src.Area.Nombre))
                .ForMember(dst => dst.AreaTamaño, options => options.MapFrom(src => src.Area.Tamaño))
                .ReverseMap();

            CreateMap<Funcion, FuncionMiniDTO>()
                .ForMember(dst => dst.AreaNombre, options => options.MapFrom(src => src.Area.Nombre))
                .ForMember(dst => dst.AreaTamaño, options => options.MapFrom(src => src.Area.Tamaño))
                .ReverseMap();

            CreateMap<Funcion, FuncionPostDTO>()
                .ReverseMap();

            CreateMap<FuncionDTO, FuncionMiniDTO>()
                .ReverseMap();
        }
    }
}
