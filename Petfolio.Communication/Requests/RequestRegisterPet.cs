using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Requests
{
    public class RequestRegisterPet
    {
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public PetType Type { get; set; }
    }
}
