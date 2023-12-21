using GymBusiness.Abstractions;
using GymDomain.Abstractions;
using GymDomain.Entities;

namespace GymBusiness.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;

        public MemberService(IMemberRepository memberRepository)
        {
            _repository = memberRepository;
        }

        public async Task<Member> CreateAsync(Member member)
        {
            return await _repository.AddMemberAsync(member);
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
            return await _repository.DeleteMemberAsync(id);
        }
    }
}
