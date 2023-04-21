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
                .ForMember(dst => dst.HospitalNombre, options => options.MapFrom(src => src.Hospital.Nombre))
                .ForMember(dst => dst.HospitalLocalizacion, options => options.MapFrom(src => src.Hospital.Localizacion))
                .ForMember(dst => dst.HospitalEspecialidades, options => options.MapFrom(src => src.Hospital.Especialidad))
                .ReverseMap();

            CreateMap<Area, AreaMiniDTO>()
                .ForMember(dst => dst.HospitalNombre, options => options.MapFrom(src => src.Hospital.Nombre))
                .ForMember(dst => dst.HospitalLocalizacion, options => options.MapFrom(src => src.Hospital.Localizacion))
                .ForMember(dst => dst.HospitalEspecialidades, options => options.MapFrom(src => src.Hospital.Especialidad))
                .ReverseMap();

            CreateMap<Area, AreaPostDTO>()
                .ReverseMap();

            CreateMap<AreaDTO, AreaMiniDTO>()
                .ReverseMap();
        }
    }
}
