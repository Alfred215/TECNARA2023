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
                .ReverseMap();

            CreateMap<Medico, MedicoMiniDTO>()
                .ReverseMap();

            CreateMap<Medico, MedicoPostDTO>()
                .ReverseMap();

            CreateMap<MedicoDTO, MedicoMiniDTO>()
                .ReverseMap();
        }
    }
}
