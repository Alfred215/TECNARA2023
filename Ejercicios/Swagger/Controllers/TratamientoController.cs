using AutoMapper;
using Data;
using Infraestructure.DTO.DiagnosticoDTOs;
using Infraestructure.DTO.TratamientoDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TratamientoController : ControllerBase
    {
        private readonly ILogger<TratamientoController> _logger;
        private readonly IMapper mapper;

        private readonly TratamientoService tratamientoSV;

        public TratamientoController(ILogger<TratamientoController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            tratamientoSV = new TratamientoService(_db);
        }
        #region GET
        [HttpGet("GetListTratamiento")]
        [ProducesResponseType(typeof(List<TratamientoMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListTratamientoAsync()
        {
            var result = await tratamientoSV.GetListAsync();
            var resultMap = mapper.Map<List<TratamientoMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetTratamientoById")]
        [ProducesResponseType(typeof(TratamientoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTratamientoByIdAsync(
            [FromBody] Guid id)
        {
            var result = await tratamientoSV.GetByIdAsync(id);
            var resultMap = mapper.Map<TratamientoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT
        [HttpPost("AddEditTratamiento")]
        [ProducesResponseType(typeof(TratamientoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditTratamientoAsync(
            [FromBody] TratamientoPostDTO tratamiento)
        {
            var result = await tratamientoSV.AddEditAsync(mapper.Map<Tratamiento>(tratamiento));
            var resultMap = mapper.Map<TratamientoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE 
        [HttpDelete("DeleteTratamientoById")]
        [ProducesResponseType(typeof(TratamientoMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteTratamientoByIdAsync(
            [FromBody] Guid id)
        {
            var result = await tratamientoSV.DeleteAsync(id);
            var resultMap = mapper.Map<TratamientoMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

    }
}
