using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Responses
{
    public class ResponseShortPet
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public PetType PetType { get; set; }
    }
}
