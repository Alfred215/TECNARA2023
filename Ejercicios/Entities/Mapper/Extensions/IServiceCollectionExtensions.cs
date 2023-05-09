using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapper.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddEntityMapper(this IServiceCollection services)
        {
            var service = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Profiles.MapperProfileArea());
                mc.AddProfile(new Profiles.MapperProfileDiagnostico());
                mc.AddProfile(new Profiles.MapperProfileDiagnosticoTratamiento());
                mc.AddProfile(new Profiles.MapperProfileEnfermedad());
                mc.AddProfile(new Profiles.MapperProfileFuncion());
                mc.AddProfile(new Profiles.MapperProfileHospital());
                mc.AddProfile(new Profiles.MapperProfileMedico());
                mc.AddProfile(new Profiles.MapperProfilePaciente());
                mc.AddProfile(new Profiles.MapperProfilePacienteEnfermedad());
                mc.AddProfile(new Profiles.MapperProfilePerson());
                mc.AddProfile(new Profiles.MapperProfileTratamiento());

            }).CreateMapper();
            return services.AddSingleton(service);
        }
    }
}
