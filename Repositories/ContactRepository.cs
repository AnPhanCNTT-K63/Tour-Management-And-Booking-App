using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
        }
    }
}
