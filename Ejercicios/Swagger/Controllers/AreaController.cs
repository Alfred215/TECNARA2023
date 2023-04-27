using AutoMapper;
using Data;
using Infraestructure.DTO.AreaDTOs;
using Infraestructure.DTO.PersonDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly ILogger<AreaController> _logger;
        private readonly IMapper mapper;

        private readonly AreaService areaSV;

        public AreaController(ILogger<AreaController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            areaSV = new AreaService(_db);
        }

        #region GET
        [HttpGet("GetListArea")]
        [ProducesResponseType(typeof(List<AreaMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListAreaAsync()
        {
            var result = await areaSV.GetListAsync();
            var resultMap = mapper.Map<List<AreaMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetAreaById")]
        [ProducesResponseType(typeof(AreaMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAreaByIdAsync(
            [FromBody] Guid id)
        {
            var result = await areaSV.GetByIdAsync(id);
            var resultMap = mapper.Map<AreaMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT
        [HttpPost("AddEditArea")]
        [ProducesResponseType(typeof(AreaMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditAreaAsync(
            [FromBody] AreaPostDTO area)
        {
            var result = await areaSV.AddEditAsync(mapper.Map<Area>(area));
            var resultMap = mapper.Map<AreaMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE 
        [HttpDelete("DeleteAreaById")]
        [ProducesResponseType(typeof(AreaMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteAreaByIdAsync(
            [FromBody] Guid id)
        {
            var result = await areaSV.DeleteAsync(id);
            var resultMap = mapper.Map<AreaMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion
    }
}
