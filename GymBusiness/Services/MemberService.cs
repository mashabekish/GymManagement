using GymDomain.Entities;
using GymDomain.Repositories;

namespace GymBusiness.Services
{
    public class MemberService
    {
        private readonly IMemberRepository _repository;

        public MemberService(IMemberRepository memberRepository)
        {
            _repository = memberRepository;
        }

        public Member CreateAsync(Member member)
        {
            return _repository.AddMember(member);
        }

        public Member ViewAsync(int id)
        {
            return _repository.View(id);
        }

        public IEnumerable<Member> ListAsync()
        {
            return _repository.List();
        }

        public Member UpdateAsync(Member member)
        {
            return _repository.UpdateMember(member);
        }

        public Member DeleteAsync(int id)
        {
            return _repository.DeleteMember(id);
        }
    }
}
