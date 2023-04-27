using AutoMapper;
using Data;
using Infraestructure.DTO.DiagnosticoDTOs;
using Infraestructure.DTO.EnfermedadDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosticoController : ControllerBase
    {
        private readonly ILogger<DiagnosticoController> _logger;
        private readonly IMapper mapper;

        private readonly DiagnosticoService diagnosticoSV;

        public DiagnosticoController(ILogger<DiagnosticoController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            diagnosticoSV = new DiagnosticoService(_db);
        }

        #region GET
        [HttpGet("GetListDiagnostico")]
        [ProducesResponseType(typeof(List<DiagnosticoMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListDiagnosticoAsync()
        {
            var result = await diagnosticoSV.GetListAsync();
            var resultMap = mapper.Map<List<DiagnosticoMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetDiagnosticoById")]
        [ProducesResponseType(typeof(DiagnosticoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDiagnosticoByIdAsync(
            [FromBody] Guid id)
        {
            var result = await diagnosticoSV.GetByIdAsync(id);
            var resultMap = mapper.Map<DiagnosticoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT
        [HttpPost("AddEditDiagnostico")]
        [ProducesResponseType(typeof(DiagnosticoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditDiagnosticoAsync(
            [FromBody] DiagnosticoPostDTO diagnostico)
        {
            var result = await diagnosticoSV.AddEditAsync(mapper.Map<Diagnostico>(diagnostico));
            var resultMap = mapper.Map<DiagnosticoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE 
        [HttpDelete("DeleteDiagnosticoById")]
        [ProducesResponseType(typeof(DiagnosticoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteDiagnosticoByIdAsync(
            [FromBody] Guid id)
        {
            var result = await diagnosticoSV.DeleteAsync(id);
            var resultMap = mapper.Map<DiagnosticoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion
    }
}
