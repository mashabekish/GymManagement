using GymDomain.Entities;

namespace GymDomain.Abstractions
{
    public interface ISubscriptionRepository
    {
        Task<Subscription> ViewAsync(int code);
        Task<Subscription> AddSubscriptionAsync(Subscription sub);
        Task<IEnumerable<Subscription>> ListAsync();
        Task<Subscription> UpdateSubscriptionAsync(Subscription sub);
        Task<Subscription> DeleteSubscriptionAsync(int id);
    }
}
