using AutoMapper;
using Data;
using Infraestructure.DTO.CustomerDTOs;
using Infraestructure.DTO.PersonDTOs;
using Infraestructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Services.PersonServices;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IMapper mapper;

        private readonly IPersonService personSV;

        public PersonController(ILogger<PersonController> logger, IMapper _mapper, IPersonService _personSV)
        {
            _logger = logger;
            mapper = _mapper;
            personSV = _personSV;
        }

        #region GET PERSON
        [HttpGet("GetListPerson")]
        [ProducesResponseType(typeof(List<PersonMiniDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListPersonAsync()
        {
            var result = await personSV.GetListAsync();
            var resultMap = mapper.Map<List<PersonMiniDTO>>(result);

            return Ok(resultMap);
        }

        [HttpPost("GetPersonById/{id}")]
        [ProducesResponseType(typeof(PersonMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPersonByIdAsync(
            Guid id)
        {
            var result = await personSV.GetByIdAsync(id);
            var resultMap = mapper.Map<PersonMiniDTO>(result);

            return Ok(resultMap);
        }
        #endregion

        #region ADD_EDIT PERSON
        [HttpPost("AddEditPerson")]
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
        [HttpDelete("DeletePersonById/{id}")]
        [ProducesResponseType(typeof(PersonMiniDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeletePersonByIdAsync(
            Guid id)
        {
            var result = await personSV.DeleteAsync(id);
            var resultMap = mapper.Map<PersonDTO>(result);

            return Ok(resultMap);
        } 
        #endregion
    }
}
