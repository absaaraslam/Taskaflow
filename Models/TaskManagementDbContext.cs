using Microsoft.EntityFrameworkCore;

namespace TaskManagementProject.Models
{
	public class TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) : DbContext(options)
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Tasks> Tasks { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Tasks>()
		   .HasKey(t => t.TaskId);

			modelBuilder.Entity<Category>()
			.HasKey(c => c.CategoryId);

			modelBuilder.Entity<Tasks>()
				.HasOne(t => t.Category)
				.WithMany(c => c.Tasks)
				.HasForeignKey(t => t.CategoryId);
		}
	}
}
