using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Responses
{
    public class ResponsePet
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public PetType Type { get; set; }
    }
}
