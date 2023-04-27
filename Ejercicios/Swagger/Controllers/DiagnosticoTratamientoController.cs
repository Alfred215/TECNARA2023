using AutoMapper;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosticoTratamientoController : ControllerBase
    {
        private readonly ILogger<DiagnosticoTratamientoController> _logger;
        private readonly IMapper mapper;

        private readonly DiagnosticoTratamientoService diagnosticoTratamientoSV;

        public DiagnosticoTratamientoController(ILogger<DiagnosticoTratamientoController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            diagnosticoTratamientoSV = new DiagnosticoTratamientoService(_db);
        }
    }
}
