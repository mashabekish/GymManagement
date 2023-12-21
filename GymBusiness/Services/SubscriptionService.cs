namespace GymBusiness.Services
{
    public class SubscriptionService
    {
        private readonly SubscriptionRepository _repository;

        public SubscriptionService(SubscriptionRepository subscriptionRepository)
        {
            _repository = subscriptionRepository;
        }

        public Subscription CreateAsync(Subscription subscription)
        {
            return _repository.CreateAsync(subscription);
        }

        public Subscription ViewAsync(int id)
        {
            return _repository.ViewAsync(id);
        }

        public IList<Subscription> ListAsync()
        {
            return _repository.ListAsync();
        }

        public Subscription UpdateAsync(Subscription subscription)
        {
            return _repository.UpdateAsync(subscription);
        }

        public Subscription DeleteAsync(int id)
        {
            return _repository.DeleteAsync(member);
        }
    }
}
