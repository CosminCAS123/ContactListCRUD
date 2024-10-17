using ContactListCRUD.Models;
using ContactListCRUD.Repositories;

namespace ContactListCRUD.Services
{
    public class ContactService
    {

        private IContactRepository contactRepository;
        public ContactService(IContactRepository contact_repo)
        {
            this.contactRepository = contact_repo;
        }

        public async Task AddContactAsync(Contact contact)
        {
         await this.contactRepository.AddContactAsync(contact);
         await this.contactRepository.SaveChangesAsync();
        }
        public async Task<Contact> GetContactByIdAsync(int id)
        {
            return await this.contactRepository.GetByIdAsync(id);
        }

        public async Task<List<Contact>> GetContactsAsync()
        {
            return await this.contactRepository.GetAllContactsAsync();
        }

        public async Task UpdateContactAsync(Contact contact)
        {

          await  this.contactRepository.UpdateContactAsync(contact);
            await this.contactRepository.SaveChangesAsync();
        }

    }
}
