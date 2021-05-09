using Microsoft.EntityFrameworkCore;
using TodoGeneric.Entities.Todo;



// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TodoGeneric.Infrastructure.Data
{
    public partial class TodoGenericContext : DbContext
    {
        public TodoGenericContext()
        {
        }

        public TodoGenericContext(DbContextOptions<TodoGenericContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Todo> Todo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .HasColumnName("TodoId");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });
        }
    }
}
