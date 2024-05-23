using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementProject.Areas.Identity.Data;

namespace TaskManagementProject.Areas.Identity.Data;

public class DBTaskManagementContextSample : IdentityDbContext<TaskManagementProjectUser>
{
    public DBTaskManagementContextSample(DbContextOptions<DBTaskManagementContextSample> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        //builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

//public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<TaskManagementProjectUser>
//{
//    public void Configure(EntityTypeBuilder<TaskManagementProjectUser> builder)
//    {
//    }
//}