using AutoMapper;
using Infraestructure.DTO.EnfermedadDTOs;
using Infraestructure.DTO.TratamientoDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileTratamiento : Profile
    {
        public MapperProfileTratamiento() 
        {
            CreateMap<Tratamiento, TratamientoDTO>()
                    .ForMember(dst => dst.EnfermedadNombre, options => options.MapFrom(src => src.Enfermedad.Nombre))
                    .ForMember(dst => dst.EnfermedadRiesgo, options => options.MapFrom(src => src.Enfermedad.Riesgo))
                    .ReverseMap();

            CreateMap<Tratamiento, TratamientoMiniDTO>()
                .ForMember(dst => dst.EnfermedadNombre, options => options.MapFrom(src => src.Enfermedad.Nombre))
                .ForMember(dst => dst.EnfermedadRiesgo, options => options.MapFrom(src => src.Enfermedad.Riesgo))
                .ReverseMap();

            CreateMap<Tratamiento, TratamientoPostDTO>()
                .ReverseMap();

            CreateMap<TratamientoDTO, TratamientoMiniDTO>()
                .ReverseMap();
        }
    }
}
