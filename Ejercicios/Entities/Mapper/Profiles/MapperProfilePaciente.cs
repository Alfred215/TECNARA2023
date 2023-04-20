using AutoMapper;
using Infraestructure.DTO.PacienteDTOs;
using Infraestructure.DTO.PersonDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfilePaciente : Profile
    {
        public MapperProfilePaciente()
        {
            CreateMap<Paciente, PacienteDTO>()
                .ForMember(dst => dst.PersonaNombre, options => options.MapFrom(src => src.Persona.Name))
                .ForMember(dst => dst.PersonaPApellido, options => options.MapFrom(src => src.Persona.Surname1))
                .ForMember(dst => dst.PersonaSApellido, options => options.MapFrom(src => src.Persona.Surname2))
                .ForMember(dst => dst.PersonaEdad, options => options.MapFrom(src => src.Persona.Age))
                .ForMember(dst => dst.PersonaEstado, options => options.MapFrom(src => src.Persona.Estado))
                .ForMember(dst => dst.HospitalNombre, options => options.MapFrom(src => src.Hospital.Nombre))
                .ForMember(dst => dst.HospitalLocalizacion, options => options.MapFrom(src => src.Hospital.Localizacion))
                .ForMember(dst => dst.HospitalEspecialidades, options => options.MapFrom(src => src.Hospital.Especialidad))
                .ReverseMap();

            CreateMap<Paciente, PacienteMiniDTO>()
                .ForMember(dst => dst.PersonaNombre, options => options.MapFrom(src => src.Persona.Name))
                .ForMember(dst => dst.PersonaPApellido, options => options.MapFrom(src => src.Persona.Surname1))
                .ForMember(dst => dst.PersonaSApellido, options => options.MapFrom(src => src.Persona.Surname2))
                .ForMember(dst => dst.PersonaEdad, options => options.MapFrom(src => src.Persona.Age))
                .ForMember(dst => dst.PersonaEstado, options => options.MapFrom(src => src.Persona.Estado))
                .ForMember(dst => dst.HospitalNombre, options => options.MapFrom(src => src.Hospital.Nombre))
                .ForMember(dst => dst.HospitalLocalizacion, options => options.MapFrom(src => src.Hospital.Localizacion))
                .ForMember(dst => dst.HospitalEspecialidades, options => options.MapFrom(src => src.Hospital.Especialidad))
                .ReverseMap();

            CreateMap<Paciente, PacientePostDTO>()
                .ReverseMap();

            CreateMap<PacienteDTO, PacienteMiniDTO>()
                .ReverseMap();
        }
    }
}
