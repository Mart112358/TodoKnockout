using System;
using System.Data.Entity;

namespace TodoKnockout.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<TodoDbContext>
    {
        protected override void Seed(TodoDbContext context)
        {
            base.Seed(context);
            var todos = new[]
                {
                    new Todo { Id = Guid.NewGuid(), Description = "Todo1", Done = false },
                    new Todo { Id = Guid.NewGuid(), Description = "Todo2", Done = true },
                };

            foreach (var todo in todos)
            {
                context.Todos.Add(todo);
            }

            context.SaveChanges();
        }
    }
}