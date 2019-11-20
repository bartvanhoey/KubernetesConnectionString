using Microsoft.EntityFrameworkCore;
using TodoItemsAPI.Models;

namespace TodoItemsAPI.DAL
{
    public class TodoItemDbContext : DbContext
    {
        public TodoItemDbContext(DbContextOptions<TodoItemDbContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoItemConfiguration());
        }
    }
}