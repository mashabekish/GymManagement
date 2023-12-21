using GymDomain.Entities;

namespace GymBusiness.Abstractions
{
    public interface ISubscriptionService
    {
        Task<Subscription> CreateAsync(Subscription subscription);
        Task<Subscription> ViewAsync(int id);
        Task<IEnumerable<Subscription>> ListAsync();
        Task<Subscription> UpdateAsync(Subscription subscription);
        Task<Subscription> DeleteAsync(int id);
    }
}
