using AutoMapper;
using Infraestructure.DTO.PacienteEnfermedadDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfilePacienteEnfermedad : Profile
    {
        public MapperProfilePacienteEnfermedad()
        {
            CreateMap<PacienteEnfermedad, PacienteEnfermedadDTO>()
                .ForMember(dst => dst.EnfermedadNombre, options => options.MapFrom(src => src.Enfermedad.Nombre))
                .ForMember(dst => dst.EnfermedadRiesgo, options => options.MapFrom(src => src.Enfermedad.Riesgo))
                .ForMember(dst => dst.PacienteFecha, options => options.MapFrom(src => src.Paciente.Fecha))
                .ForMember(dst => dst.PacienteMotivo, options => options.MapFrom(src => src.Paciente.Motivo))
                .ReverseMap();

            CreateMap<PacienteEnfermedad, PacienteEnfermedadMiniDTO>()
                .ForMember(dst => dst.EnfermedadNombre, options => options.MapFrom(src => src.Enfermedad.Nombre))
                .ForMember(dst => dst.EnfermedadRiesgo, options => options.MapFrom(src => src.Enfermedad.Riesgo))
                .ForMember(dst => dst.PacienteFecha, options => options.MapFrom(src => src.Paciente.Fecha))
                .ForMember(dst => dst.PacienteMotivo, options => options.MapFrom(src => src.Paciente.Motivo))
                .ReverseMap();

            CreateMap<PacienteEnfermedad, PacienteEnfermedadPostDTO>()
            .ReverseMap();

            CreateMap<PacienteEnfermedadDTO, PacienteEnfermedadMiniDTO>()
                .ReverseMap();
        }
    }
}
