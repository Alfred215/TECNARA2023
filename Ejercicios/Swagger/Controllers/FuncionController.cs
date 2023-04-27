using AutoMapper;
using Data;
using Infraestructure.DTO.AreaDTOs;
using Infraestructure.DTO.FuncionDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionController : ControllerBase
    {
        private readonly ILogger<FuncionController> _logger;
        private readonly IMapper mapper;

        private readonly AppDbContext db;
        private readonly FuncionService funcionSV;

        public FuncionController(ILogger<FuncionController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            db = _db;
            funcionSV = new FuncionService(_db);
        }

        #region GET
        [HttpGet("GetListFuncion")]
        [ProducesResponseType(typeof(List<FuncionMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListFuncionAsync()
        {
            var result = await funcionSV.GetListAsync();
            var resultMap = mapper.Map<List<FuncionMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetFuncionById")]
        [ProducesResponseType(typeof(FuncionMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFuncionByIdAsync(
            [FromBody] Guid id)
        {
            var result = await funcionSV.GetByIdAsync(id);
            var resultMap = mapper.Map<FuncionMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT
        [HttpPost("AddEditFuncion")]
        [ProducesResponseType(typeof(FuncionMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditFuncionAsync(
            [FromBody] FuncionPostDTO funcion)
        {
            var result = await funcionSV.AddEditAsync(mapper.Map<Funcion>(funcion));
            var resultMap = mapper.Map<FuncionMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE 
        [HttpDelete("DeleteFuncionById")]
        [ProducesResponseType(typeof(FuncionMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteFuncionByIdAsync(
            [FromBody] Guid id)
        {
            var result = await funcionSV.DeleteAsync(id);
            var resultMap = mapper.Map<FuncionMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion
    }
}
