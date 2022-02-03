using System.Data.Entity;


namespace BraveLittleTodoList.Model
{
    class tlDBContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
