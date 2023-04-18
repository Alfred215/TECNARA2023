using AutoMapper;
using BD_Swagger;
using Infraestructure.DTO.CustomerDTOs;
using Infraestructure.DTO.PersonDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IMapper mapper;

        private readonly AppDbContext db;
        private readonly PersonService personSV;

        public PersonController(ILogger<PersonController> logger, IMapper _mapper, AppDbContext _db)
        {
            _logger = logger;
            mapper = _mapper;
            db = _db;
            personSV = new PersonService(_db);
        }

        #region GET PERSON
        [HttpGet("GetListPerson")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(List<PersonMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListPersonAsync()
        {
            var result = await personSV.GetListAsync();
            var resultMap = mapper.Map<List<PersonMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetPersonById")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(PersonMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await personSV.GetByIdAsync(id);
            var resultMap = mapper.Map<PersonMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT PERSON
        [HttpPost("AddEditPerson")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(PersonMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddEditPersonAsync(
            [FromBody] PersonPostDTO person)
        {
            var result = await personSV.AddEditAsync(mapper.Map<Person>(person));
            var resultMap = mapper.Map<PersonDTO> (result);

            return Ok(resultMap);
        }
        #endregion

        #region DELETE PERSON
        [HttpDelete("DeletePersonById")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(PersonMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeletePersonByIdAsync(
            [FromBody] Guid id)
        {
            var result = await personSV.DeleteAsync(id);
            var resultMap = mapper.Map<PersonDTO>(result);

            return Ok(resultMap);
        } 
        #endregion
    }
}
