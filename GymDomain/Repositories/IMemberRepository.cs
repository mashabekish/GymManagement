using GymDomain.Entities;

namespace GymDomain.Repositories
{
    public interface IMemberRepository
    {
        Task<Member> ViewAsync(int id);
        Task<Member> AddMemberAsync(Member member);
        Task<IEnumerable<Member>> ListAsync();
        Task<Member> UpdateMemberAsync(Member member);
        Task<Member> DeleteMemberAsync(int id);
    }
}
