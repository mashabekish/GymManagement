using GymBusiness.Abstractions;
using GymDomain.Abstractions;
using GymDomain.Entities;
using GymDomain.Repositories;

namespace GymBusiness.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;
        private readonly ISubscriptionRepository _subscriptionRepository;

        public MemberService(IMemberRepository memberRepository, ISubscriptionRepository subscriptionRepository)
        {
            _repository = memberRepository;
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<Member> CreateAsync(Member member)
        {            
            member.IdCardNumber = Guid.NewGuid();

            return await _repository.AddMemberAsync(member); ;
        }

        public async Task<Member> ViewAsync(int id)
        {
            return await _repository.ViewAsync(id);
        }

        public async Task<IEnumerable<Member>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<Member> UpdateAsync(Member member)
        {
            return await _repository.UpdateMemberAsync(member);
        }

        public async Task<Member> DeleteAsync(int id)
        {
            var memberToDelete = await _repository.ViewAsync(id);

            await _subscriptionRepository.DeleteSubscriptionAsync(memberToDelete.Id);

            return await _repository.DeleteMemberAsync(id);
        }
    }
}
