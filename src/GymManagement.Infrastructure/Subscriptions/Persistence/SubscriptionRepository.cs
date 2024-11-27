using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Peristence;

namespace GymManagement.Infrastructure.Subscriptions.Persistence;

public class SubscriptionRepository: ISubscriptionsRepository
{
    private readonly GymManagementDbContext _dbContext;

    public SubscriptionRepository(GymManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddSubscriptionAsync(Subscription subscription)
    {
        _dbContext.Subscriptions.Add(subscription);
    }

    public async Task<Subscription?> GetSubscriptionAsync(Guid subscriptionId)
    {
        return await _dbContext.Subscriptions.FindAsync(subscriptionId);
    }
}