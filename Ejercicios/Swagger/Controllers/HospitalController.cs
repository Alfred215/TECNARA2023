using AutoMapper;
using Data;
using Infraestructure.DTO.HospitalDTOs;
using Infraestructure.DTO.PacienteDTOs;
using Infraestructure.Entities;
using Infraestructure.Enumerables;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly ILogger<HospitalController> _logger;
        private readonly IMapper mapper;

        private readonly AppDbContext db;
        private readonly HospitalService hospitalSV;

        public HospitalController(ILogger<HospitalController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            db = _db;
            hospitalSV = new HospitalService(_db);
        }

        #region GET HOSPITAL
        [HttpGet("GetListHospital")]
        [ProducesResponseType(typeof(List<HospitalMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListPersonAsync()
        {
            var result = await hospitalSV.GetListAsync();
            var resultMap = mapper.Map<List<HospitalMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetHospitalById")]
        [ProducesResponseType(typeof(HospitalMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await hospitalSV.GetByIdAsync(id);
            var resultMap = mapper.Map<HospitalMiniDTO>(result);

            return Ok(resultMap);
        }

        [HttpGet("GetListHospitalesActual")]
        [ProducesResponseType(typeof(List<HospitalMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListHospitalesActualAsync()
        {
            var result = await hospitalSV.GetListHospitalesActualAsync();

            return Ok(result);
        }

        [HttpGet("GetListHospitalesByMotivoPacient")]
        [ProducesResponseType(typeof(List<HospitalMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListHospitalesByMotivoPacientAsync(
            MotivoPacienteType motivo)
        {
            var result = await hospitalSV.GetListHospitalesByMotivoPaciente(motivo);

            return Ok(result);
        }
        #endregion

        #region ADD_EDIT HOSPITAL
        [HttpPost("AddEditHospital")]
        [ProducesResponseType(typeof(HospitalMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditPersonAsync(
            [FromBody] HospitalPostDTO hospital)
        {
            var result = await hospitalSV.AddEditAsync(mapper.Map<Hospital>(hospital));
            var resultMap = mapper.Map<HospitalMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE HOSPITAL
        [HttpDelete("DeleteHospitalById")]
        [ProducesResponseType(typeof(HospitalMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeletePersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await hospitalSV.DeleteAsync(id);
            var resultMap = mapper.Map<HospitalMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion
    }
}
