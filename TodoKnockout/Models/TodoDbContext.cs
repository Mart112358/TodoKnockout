using System.Data.Entity;

namespace TodoKnockout.Models
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
    }
}