using MetaSoftAppWeb.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using MetaSoftAppWeb.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions.Extensions;
using Microsoft.EntityFrameworkCore;

namespace MetaSoftAppWeb.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.UseSnakeCaseNamingConvention();
    }
}