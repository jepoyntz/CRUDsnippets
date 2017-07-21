using Microsoft.EntityFrameworkCore;
using CrudSnippets.Models;

namespace SnippetApp.Models
{
    public class MyDbContext : DbContext
    {
        
        public DbSet<Snippet> Snippets { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
         {                    
            optionsBuilder.UseSqlite("Data Source=snippets.db");
         }

    }
}