namespace GymBusiness.Services
{
    public class MemberSubscriptionService
    {
        private readonly MemberSubscriptionRepository _repository;

        public MemberSubscriptionService(MemberSubscriptionRepository memberSubscriptionRepository)
        {
            _repository = memberSubscriptionRepository;
        }

        public MemberSubscription CreateAsync(MemberSubscription subscription)
        {
            return _repository.CreateAsync(subscription);
        }

        public MemberSubscription ViewAsync(int id)
        {
            return _repository.ViewAsync(id);
        }

        public IList<MemberSubscription> ListAsync()
        {
            return _repository.ListAsync();
        }

        public MemberSubscription UpdateAsync(MemberSubscription subscription)
        {
            return _repository.UpdateAsync(subscription);
        }

        public MemberSubscription DeleteAsync(int id)
        {
            return _repository.DeleteAsync(member);
        }
    }
}
