using GymDomain.Abstractions;
using GymDomain.Entities;

namespace GymBusiness.Services
{
    public class SubscriptionService
    {
        private readonly ISubscriptionRepository _repository;

        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            _repository = subscriptionRepository;
        }

        public Subscription CreateAsync(Subscription subscription)
        {
            return _repository.AddSubsctiption(subscription);
        }

        public Subscription ViewAsync(int id)
        {
            return _repository.View(id);
        }

        public IEnumerable<Subscription> ListAsync()
        {
            return _repository.List();
        }

        public Subscription UpdateAsync(Subscription subscription)
        {
            return _repository.UpdateSubscription(subscription);
        }

        public Subscription DeleteAsync(int id)
        {
            return _repository.DeleteSubscription(id);
        }
    }
}
