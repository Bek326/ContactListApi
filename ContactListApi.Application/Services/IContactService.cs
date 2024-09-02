using ContactListApi.Domain;

namespace ContactListApi.Application.Services;

public interface IContactService
{
    Task<List<Contact>> GetAllContactsAsync();
    Task<Contact> GetContactByIdAsync(int id);
    Task<Contact> CreateContactAsync(Contact contact);
    Task UpdateContactAsync(Contact contact);
    Task DeleteContactAsync(int id);
}