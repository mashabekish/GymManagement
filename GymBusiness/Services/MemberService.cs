namespace GymBusiness.Services
{
    public class MemberService
    {
        private readonly MemberRepository _repository;

        public MemberService(MemberRepository memberRepository)
        {
            _repository = memberRepository;
        }

        public Member CreateAsync(Member member)
        {
            return _repository.CreateAsync(member);
        }

        public Member ViewAsync(int id)
        {
            return _repository.ViewAsync(id);
        }

        public IList<Member> ListAsync()
        {
            return _repository.ListAsync();
        }

        public Member UpdateAsync(Member member)
        {
            return _repository.UpdateAsync(member);
        }

        public Member DeleteAsync(int id)
        {
            return _repository.DeleteAsync(member);
        }
    }
}
