using GymDomain.Abstractions;
using GymDomain.Entities;

namespace GymBusiness.Services
{
    public class MemberSubscriptionService
    {
        private readonly IMemberSubscriptionRepository _repository;

        public MemberSubscriptionService(IMemberSubscriptionRepository memberSubscriptionRepository)
        {
            _repository = memberSubscriptionRepository;
        }

        public MemberSubscription CreateAsync(MemberSubscription subscription)
        {
            return _repository.AddMemberSub(subscription);
        }

        public MemberSubscription ViewAsync(int id)
        {
            return _repository.View(id);
        }

        public IEnumerable<MemberSubscription> ListAsync()
        {
            return _repository.List();
        }

        public MemberSubscription UpdateAsync(MemberSubscription subscription)
        {
            return _repository.UpdateMemberSub(subscription);
        }

        public MemberSubscription DeleteAsync(int id)
        {
            return _repository.DeleteMemberSub(id);
        }
    }
}
