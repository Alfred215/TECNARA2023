using AutoMapper;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteEnfermedadController : ControllerBase
    {
        private readonly ILogger<PacienteEnfermedadController> _logger;
        private readonly IMapper mapper;

        private readonly PacienteEnfermedadService pacienteEnfermedadSV;

        public PacienteEnfermedadController(ILogger<PacienteEnfermedadController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            pacienteEnfermedadSV = new PacienteEnfermedadService(_db);
        }
    }
}
