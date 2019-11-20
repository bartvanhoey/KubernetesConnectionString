using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoItemsAPI.Models;

namespace TodoItemsAPI.DAL
{
    public class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {
            builder.ToTable("TodoItem");
            builder.Property(s => s.Id)
                .IsRequired(true);
            builder.Property(s => s.Name)
                .IsRequired(true);
            builder.Property(s => s.IsComplete)
                .HasDefaultValue(false);

            builder.HasData
            (
                new TodoItem
                {
                    Id = 1,
                    Name = "Drink Coffee",
                    IsComplete = false
                },
                new TodoItem
                {
                    Id = 2,
                    Name = "Brush Teeth",
                    IsComplete = false
                },
                new TodoItem
                {
                    Id = 3,
                    Name = "Go to Work",
                    IsComplete = true
                },
                new TodoItem
                {
                    Id = 4,
                    Name = "Clean Windows",
                    IsComplete = true
                }
            );
        }
    }
}