using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Infrastructure.Common.Peristence;

public class GymManagementDbContext : DbContext, IUnitOfWork
{
    public DbSet<Subscription> Subscriptions { get; init; }

    public GymManagementDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public async Task CommitChangesAsync()
    {
        await base.SaveChangesAsync();
    }
}