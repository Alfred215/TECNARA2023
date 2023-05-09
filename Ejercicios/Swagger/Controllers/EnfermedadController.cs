using AutoMapper;
using Data;
using Infraestructure.DTO.EnfermedadDTOs;
using Infraestructure.DTO.FuncionDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnfermedadController : ControllerBase
    {
        private readonly ILogger<EnfermedadController> _logger;
        private readonly IMapper mapper;

        private readonly EnfermedadService enfermedadSV;

        public EnfermedadController(ILogger<EnfermedadController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            enfermedadSV = new EnfermedadService(_db);
        }

        #region GET
        [HttpGet("GetListEnfermedad")]
        [ProducesResponseType(typeof(List<EnfermedadMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListFuncionAsync()
        {
            var result = await enfermedadSV.GetListAsync();
            var resultMap = mapper.Map<List<EnfermedadMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetEnfermedadById")]
        [ProducesResponseType(typeof(EnfermedadMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetEnfermedadByIdAsync(
            [FromBody] Guid id)
        {
            var result = await enfermedadSV.GetByIdAsync(id);
            var resultMap = mapper.Map<EnfermedadMiniDTO>(result);

            return Ok(resultMap);
        }
        
        [HttpPost("GetEnfermedadMostRepeated")]
        [ProducesResponseType(typeof(EnfermedadMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetEnfermedadMostRepeated()
        {
            var result = await enfermedadSV.GetEnfermedadMostRepeated();
            var resultMap = mapper.Map<EnfermedadMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT
        [HttpPost("AddEditEnfermedad")]
        [ProducesResponseType(typeof(EnfermedadMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditEnfermedadAsync(
            [FromBody] EnfermedadPostDTO enfermedad)
        {
            var result = await enfermedadSV.AddEditAsync(mapper.Map<Enfermedad>(enfermedad));
            var resultMap = mapper.Map<EnfermedadMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE 
        [HttpDelete("DeleteEnfermedadById")]
        [ProducesResponseType(typeof(EnfermedadMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteEnfermedadByIdAsync(
            [FromBody] Guid id)
        {
            var result = await enfermedadSV.DeleteAsync(id);
            var resultMap = mapper.Map<EnfermedadMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion
    }
}
