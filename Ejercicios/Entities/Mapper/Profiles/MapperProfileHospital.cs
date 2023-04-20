using AutoMapper;
using Infraestructure.DTO.HospitalDTOs;
using Infraestructure.DTO.PersonDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileHospital : Profile
    {
        public MapperProfileHospital()
        {
            CreateMap<Hospital, HospitalDTO>()
                .ReverseMap();

            CreateMap<Hospital, HospitalMiniDTO>()
                .ReverseMap();

            CreateMap<Hospital, HospitalPostDTO>()
                .ReverseMap();

            CreateMap<HospitalDTO, HospitalMiniDTO>()
                .ReverseMap();
        }
    }
}
