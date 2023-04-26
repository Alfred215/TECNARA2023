using AutoMapper;
using Infraestructure.DTO.DiagnosticoDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileDiagnostico : Profile
    {
        public MapperProfileDiagnostico() 
        {
            CreateMap<Diagnostico, DiagnosticoDTO>()
                    .ForMember(dst => dst.PacienteFecha, options => options.MapFrom(src => src.Paciente.Fecha))
                    .ForMember(dst => dst.PacienteMotivo, options => options.MapFrom(src => src.Paciente.Motivo))
                    .ForMember(dst => dst.MedicoHorasDia, options => options.MapFrom(src => src.Medico.HorasDia))
                    .ReverseMap();

            CreateMap<Diagnostico, DiagnosticoMiniDTO>()
                .ForMember(dst => dst.PacienteFecha, options => options.MapFrom(src => src.Paciente.Fecha))
                .ForMember(dst => dst.PacienteMotivo, options => options.MapFrom(src => src.Paciente.Motivo))
                .ForMember(dst => dst.MedicoHorasDia, options => options.MapFrom(src => src.Medico.HorasDia))
                .ReverseMap();

            CreateMap<Diagnostico, DiagnosticoPostDTO>()
                .ReverseMap();

            CreateMap<DiagnosticoDTO, DiagnosticoMiniDTO>()
                .ReverseMap();
        }
    }
}
