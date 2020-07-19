using Microsoft.EntityFrameworkCore;

namespace GraphQLWEBAPI.Model
{
    public class TODOContext : DbContext
    {
        public TODOContext(DbContextOptions<TODOContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
