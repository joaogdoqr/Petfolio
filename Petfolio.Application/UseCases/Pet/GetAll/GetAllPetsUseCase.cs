using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPets Execute()
        {
            return new ResponseAllPets()
            {
                Pets = new List<ResponseShortPet>()
                {
                    new ResponseShortPet()
                    {
                        Id = 1,
                        Name = "test",
                    }
                }
            };
        }
    }
}
