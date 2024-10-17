using ContactListCRUD.Data;
using ContactListCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactListCRUD.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private ContactDbContext dbContext;
        public ContactRepository(ContactDbContext dbcontext) 
        {
            this.dbContext = dbcontext;
        }

        public async Task AddContactAsync(Contact contact)
        {
            await this.dbContext.Contacts.AddAsync(contact);

        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            var list = await this.dbContext.Contacts.ToListAsync();
            return list;
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
          var contact = await this.dbContext.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            return contact;
        }

        public async Task SaveChangesAsync()
        {
            await this.dbContext.SaveChangesAsync();
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            // Fetch the existing contact from the database
            var existingContact = await GetByIdAsync(contact.Id);

            // If the contact exists, update its properties
            if (existingContact != null)
            {
                existingContact.Name = contact.Name;
                existingContact.Email = contact.Email;
                existingContact.Phone = contact.Phone;

             
              
            }
            else
            {
                throw new Exception("Contact not found.");
            }
        }
    }
}
