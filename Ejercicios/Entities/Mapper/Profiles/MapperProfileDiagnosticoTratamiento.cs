using AutoMapper;
using Infraestructure.DTO.DiagnosticoTratamientoDTOs;
using Infraestructure.DTO.EnfermedadDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileDiagnosticoTratamiento : Profile
    {
        public MapperProfileDiagnosticoTratamiento() 
        {
            CreateMap<DiagnosticoTratamiento, DiagnosticoTratamientoDTO>()
                .ForMember(dst => dst.DiagnosticoFecha, options => options.MapFrom(src => src.Diagnostico.Fecha))
                .ForMember(dst => dst.TratamientoDuracion, options => options.MapFrom(src => src.Tratamiento.Duracion))
                .ReverseMap();

            CreateMap<DiagnosticoTratamiento, DiagnosticoTratamientoMiniDTO>()
                .ForMember(dst => dst.DiagnosticoFecha, options => options.MapFrom(src => src.Diagnostico.Fecha))
                .ForMember(dst => dst.TratamientoDuracion, options => options.MapFrom(src => src.Tratamiento.Duracion))
                .ReverseMap();

            CreateMap<DiagnosticoTratamiento, DiagnosticoTratamientoPostDTO>()
                .ReverseMap();

            CreateMap<DiagnosticoTratamientoDTO, DiagnosticoTratamientoMiniDTO>()
                .ReverseMap();
        }
    }
}
