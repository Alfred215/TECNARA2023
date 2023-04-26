﻿using AutoMapper;
using Infraestructure.DTO.EnfermedadDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileEnfermedad : Profile
    {
        public MapperProfileEnfermedad() 
        {
            CreateMap<Enfermedad, EnfermedadDTO>()
                .ForMember(dst => dst.AreaNombre, options => options.MapFrom(src => src.Area.Nombre))
                .ForMember(dst => dst.AreaTamaño, options => options.MapFrom(src => src.Area.Tamaño))
                .ReverseMap();

            CreateMap<Enfermedad, EnfermedadMiniDTO>()
                .ForMember(dst => dst.AreaNombre, options => options.MapFrom(src => src.Area.Nombre))
                .ForMember(dst => dst.AreaTamaño, options => options.MapFrom(src => src.Area.Tamaño))
                .ReverseMap();

            CreateMap<Enfermedad, EnfermedadPostDTO>()
                .ReverseMap();

            CreateMap<EnfermedadDTO, EnfermedadMiniDTO>()
                .ReverseMap();
        }
    }
}
