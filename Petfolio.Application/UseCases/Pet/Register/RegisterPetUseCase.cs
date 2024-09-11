using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisterPet Execute(RequestPet request)
        {
            return new ResponseRegisterPet()
            {
                Id = Random.Shared.Next(1, 1000),
                Name = request.Name
            };
        }
    }
}
