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
    public class MedicoController : ControllerBase
    {
        private readonly ILogger<MedicoController> _logger;
        private readonly IMapper mapper;

        private readonly AppDbContext db;
        private readonly MedicoService medicoSV;

        public MedicoController(ILogger<MedicoController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            db = _db;
            medicoSV = new MedicoService(_db);
        }

        #region GET MEDICO
        [HttpGet("GetListMedico")]
        [ProducesResponseType(typeof(List<MedicoMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListPersonAsync()
        {
            var result = await medicoSV.GetListAsync();
            var resultMap = mapper.Map<List<MedicoMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetMedicoById")]
        [ProducesResponseType(typeof(MedicoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await medicoSV.GetByIdAsync(id);
            var resultMap = mapper.Map<MedicoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT MEDICO
        [HttpPost("AddEditMedico")]
        [ProducesResponseType(typeof(MedicoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditPersonAsync(
            [FromBody] MedicoPostDTO medico)
        {
            var result = await medicoSV.AddEditAsync(mapper.Map<Medico>(medico));
            var resultMap = mapper.Map<MedicoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE MEDICO
        [HttpDelete("DeleteMedicoById")]
        [ProducesResponseType(typeof(MedicoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeletePersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await medicoSV.DeleteAsync(id);
            var resultMap = mapper.Map<MedicoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion
    }
}
