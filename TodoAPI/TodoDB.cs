using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace TodoAPI
{
    public class TodoDB : DbContext
    {
        public TodoDB(DbContextOptions<TodoDB> options)
            :base(options) 
        {
                
        }

        public DbSet<TodoItem> Todos { get; set; }
    }
}
