using Microsoft.EntityFrameworkCore;
using NotesManager.Models;

namespace NotesManager;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Note> Notes { get; set; }
}
