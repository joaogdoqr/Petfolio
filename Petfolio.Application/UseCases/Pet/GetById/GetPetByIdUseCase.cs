using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePet Execute(int id)
        {
            return new ResponsePet
            {
                Id = id,
                Name = "Dog",
                BirthDate = new DateTime(year: 2012, month: 5, day: 1),
                Type = Communication.Enum.PetType.Cat
            };
        }
    }
}
