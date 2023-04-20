using AutoMapper;
using Infraestructure.DTO.AreaDTOs;
using Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Profiles
{
    public class MapperProfileArea : Profile
    {
        public MapperProfileArea()
        {
            CreateMap<Area, AreaDTO>()
                .ReverseMap();

            CreateMap<Area, AreaMiniDTO>()
                .ReverseMap();

            CreateMap<Area, AreaPostDTO>()
                .ReverseMap();

            CreateMap<AreaDTO, AreaMiniDTO>()
                .ReverseMap();
        }
    }
}
