using TravelWebBackEndCore.DTOs.Contact;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class ContactMapper
    {
        public static Contact ToContact(this CreateContactDTO createContactDTO)
        {
            return new Contact
            {
                Name = createContactDTO.Name,

                Phone = createContactDTO.Phone,
                Email = createContactDTO.Email,
            };
        }
    }
}
