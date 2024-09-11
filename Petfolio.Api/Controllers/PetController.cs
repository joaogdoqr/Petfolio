using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Delete;
using Petfolio.Application.UseCases.Pet.GetAll;
using Petfolio.Application.UseCases.Pet.GetById;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Application.UseCases.Pet.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterPet), statusCode: StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrors), statusCode: StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPet request)
        {
            var response = new RegisterPetUseCase().Execute(request);

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrors), statusCode: StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPet request)
        {
            new UpdatePetUseCase().Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPets),statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrors), statusCode: StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var response = new GetAllPetsUseCase().Execute();

            if(response.Pets.Count > 0)
            {
                return Ok(response);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponsePet), statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors),statusCode: StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new GetPetByIdUseCase().Execute(id);

            if(response == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrors), statusCode: StatusCodes.Status404NotFound)]
        public IActionResult Delete([FromRoute] int id)
        {
            new DeletePetUseCase().Execute(id);

            return NoContent();
        }
    }
}
