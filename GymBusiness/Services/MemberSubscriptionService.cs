using GymBusiness.Abstractions;
using GymDomain.Entities;
using GymDomain.Repositories;

namespace GymBusiness.Services
{
    public class MemberSubscriptionService : IMemberSubscriptionService
    {
        private readonly IMemberSubscriptionRepository _repository;

        public MemberSubscriptionService(IMemberSubscriptionRepository memberSubscriptionRepository)
        {
            _repository = memberSubscriptionRepository;
        }

        public async Task<MemberSubscription> CreateAsync(MemberSubscription subscription)
        {
            return await _repository.AddMemberSubAsync(subscription);
        }

        public async Task<MemberSubscription> ViewAsync(int id)
        {
            return await _repository.ViewAsync(id);
        }

        public async Task<IEnumerable<MemberSubscription>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<MemberSubscription> UpdateAsync(MemberSubscription subscription)
        {
            return await _repository.UpdateMemberSubAsync(subscription);
        }

        public async Task<MemberSubscription> DeleteAsync(int id)
        {
            return await _repository.DeleteMemberSubAsync(id);
        }
    }
}
