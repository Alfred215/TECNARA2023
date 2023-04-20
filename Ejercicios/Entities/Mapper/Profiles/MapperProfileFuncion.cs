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
                .ReverseMap();

            CreateMap<Funcion, FuncionMiniDTO>()
                .ReverseMap();

            CreateMap<Funcion, FuncionPostDTO>()
                .ReverseMap();

            CreateMap<FuncionDTO, FuncionMiniDTO>()
                .ReverseMap();
        }
    }
}
