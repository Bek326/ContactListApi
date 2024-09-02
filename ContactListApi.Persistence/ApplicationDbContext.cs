using ContactListApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactListApi.Persistence;

public class ApplicationDbContext: DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}