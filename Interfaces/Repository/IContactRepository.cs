using TravelWebBackEndCore.DTOs.Contact;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IContactRepository
    {
        Task AddAsync(Contact contact);
    }
}
