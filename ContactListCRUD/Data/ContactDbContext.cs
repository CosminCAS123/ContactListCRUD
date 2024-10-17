namespace ContactListCRUD.Data;
using ContactListCRUD.Models;
using Microsoft.EntityFrameworkCore;


public class ContactDbContext : DbContext
{
    public string DbPath { get; }

    public DbSet<Contact> Contacts { get; set; }
    public ContactDbContext ( )
    {
    var folder = Environment.SpecialFolder.LocalApplicationData;
    var path = Environment.GetFolderPath(folder);
    DbPath = System.IO.Path.Join(path, "contacts.db");
    }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlite($"Data Source={DbPath}");
  
}
