using GymBusiness.Abstractions;
using GymDomain.Abstractions;
using GymDomain.Entities;

namespace GymBusiness.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _repository;

        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            _repository = subscriptionRepository;
        }

        public async Task<Subscription> CreateAsync(Subscription subscription)
        {
            return await _repository.AddSubscriptionAsync(subscription);
        }

        public async Task<Subscription> ViewAsync(int id)
        {
            return await _repository.ViewAsync(id);
        }

        public async Task<IEnumerable<Subscription>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<Subscription> UpdateAsync(Subscription subscription)
        {
            return await _repository.UpdateSubscriptionAsync(subscription);
        }

        public async Task<Subscription> DeleteAsync(int id)
        {
            return await _repository.DeleteSubscriptionAsync(id);
        }
    }
}
