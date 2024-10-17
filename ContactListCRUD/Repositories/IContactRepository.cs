using ContactListCRUD.Models;

namespace ContactListCRUD.Repositories
{
    public interface IContactRepository
    {
        Task AddContactAsync(Contact contact);
        Task SaveChangesAsync();
        Task<Contact> GetByIdAsync(int id);
        Task<List<Contact>> GetAllContactsAsync();

        Task UpdateContactAsync(Contact contact);



    }
}
