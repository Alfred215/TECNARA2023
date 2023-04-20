using AutoMapper;
using Data;
using Infraestructure.DTO.MedicoDTOs;
using Infraestructure.DTO.PacienteDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly ILogger<PacienteController> _logger;
        private readonly IMapper mapper;

        private readonly AppDbContext db;
        private readonly PacienteService pacienteSV;

        public PacienteController(ILogger<PacienteController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            db = _db;
            pacienteSV = new PacienteService(_db);
        }

        #region GET PACIENTE
        [HttpGet("GetListPaciente")]
        [ProducesResponseType(typeof(List<PacienteMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListPersonAsync()
        {
            var result = await pacienteSV.GetListAsync();
            var resultMap = mapper.Map<List<PacienteMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetPacienteById")]
        [ProducesResponseType(typeof(PacienteMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await pacienteSV.GetByIdAsync(id);
            var resultMap = mapper.Map<PacienteMiniDTO>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetPersonByMedicoId")]
        [ProducesResponseType(typeof(PacienteMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPersonByMedicoIdAsync(
            [FromBody] Guid medicoId)
        {
            var result = await pacienteSV.GetPacienteByMedicoIdAsync(medicoId);

            return Ok(result);
        }
        #endregion

        #region ADD_EDIT PACIENTE
        [HttpPost("AddEditPaciente")]
        [ProducesResponseType(typeof(PacienteMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditPersonAsync(
            [FromBody] PacientePostDTO paciente)
        {
            var result = await pacienteSV.AddEditAsync(mapper.Map<Paciente>(paciente));
            var resultMap = mapper.Map<PacienteMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE PACIENTE
        [HttpDelete("DeletePacienteById")]
        [ProducesResponseType(typeof(PacienteMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeletePersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await pacienteSV.DeleteAsync(id);
            var resultMap = mapper.Map<PacienteMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion
    }
}
