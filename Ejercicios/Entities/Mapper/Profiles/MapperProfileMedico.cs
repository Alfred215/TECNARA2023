using AutoMapper;
using Infraestructure.DTO.MedicoDTOs;
using Infraestructure.DTO.PersonDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileMedico : Profile
    {
        public MapperProfileMedico()
        {
            CreateMap<Medico, MedicoDTO>()
                .ForMember(dst => dst.PersonaNombre, options => options.MapFrom(src => src.Persona.Name))
                .ForMember(dst => dst.PersonaPApellido, options => options.MapFrom(src => src.Persona.Surname1))
                .ForMember(dst => dst.PersonaSApellido, options => options.MapFrom(src => src.Persona.Surname2))
                .ForMember(dst => dst.PersonaEdad, options => options.MapFrom(src => src.Persona.Age))
                .ForMember(dst => dst.PersonaEstado, options => options.MapFrom(src => src.Persona.Estado))
                .ForMember(dst => dst.HospitalNombre, options => options.MapFrom(src => src.Hospital.Nombre))
                .ForMember(dst => dst.HospitalLocalizacion, options => options.MapFrom(src => src.Hospital.Localizacion))
                .ForMember(dst => dst.HospitalEspecialidades, options => options.MapFrom(src => src.Hospital.Especialidad))
                .ReverseMap();

            CreateMap<Medico, MedicoMiniDTO>()
                .ForMember(dst => dst.PersonaNombre, options => options.MapFrom(src => src.Persona.Name))
                .ForMember(dst => dst.PersonaPApellido, options => options.MapFrom(src => src.Persona.Surname1))
                .ForMember(dst => dst.PersonaSApellido, options => options.MapFrom(src => src.Persona.Surname2))
                .ForMember(dst => dst.PersonaEdad, options => options.MapFrom(src => src.Persona.Age))
                .ForMember(dst => dst.PersonaEstado, options => options.MapFrom(src => src.Persona.Estado))
                .ForMember(dst => dst.HospitalNombre, options => options.MapFrom(src => src.Hospital.Nombre))
                .ForMember(dst => dst.HospitalLocalizacion, options => options.MapFrom(src => src.Hospital.Localizacion))
                .ForMember(dst => dst.HospitalEspecialidades, options => options.MapFrom(src => src.Hospital.Especialidad))
                .ReverseMap();

            CreateMap<Medico, MedicoPostDTO>();

            CreateMap<MedicoPostDTO, Medico>()
                .ForMember(dst => dst.HorasDia, options => options.MapFrom(src => new TimeSpan(src.Hora, src.Minuto, src.Segundo)));

            CreateMap<MedicoDTO, MedicoMiniDTO>()
                .ReverseMap();
        }
    }
}
