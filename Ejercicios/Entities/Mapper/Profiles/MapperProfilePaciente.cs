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
                .ReverseMap();

            CreateMap<Paciente, PacienteMiniDTO>()
                .ReverseMap();

            CreateMap<Paciente, PacientePostDTO>()
                .ReverseMap();

            CreateMap<PacienteDTO, PacienteMiniDTO>()
                .ReverseMap();
        }
    }
}
