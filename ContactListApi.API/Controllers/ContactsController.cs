using ContactListApi.Application.Services;
using ContactListApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ContactListApi.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactsController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Contact>>> GetAllContacts()
    {
        return await _contactService.GetAllContactsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Contact>> GetContactById(int id)
    {
        var contact = await _contactService.GetContactByIdAsync(id);
        if (contact == null)
            return NotFound();
        return contact;
    }

    [HttpPost]
    public async Task<ActionResult<Contact>> CreateContact(Contact contact)
    {
        var createdContact = await _contactService.CreateContactAsync(contact);
        return CreatedAtAction(nameof(GetContactById), new { id = createdContact.Id }, createdContact);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContact(int id, Contact contact)
    {
        if (id != contact.Id)
            return BadRequest();

        await _contactService.UpdateContactAsync(contact);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact(int id)
    {
        await _contactService.DeleteContactAsync(id);
        return NoContent();
    }
}