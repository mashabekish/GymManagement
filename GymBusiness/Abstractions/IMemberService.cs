using GymDomain.Entities;

namespace GymBusiness.Abstractions
{
    public interface IMemberService
    {
        Task<Member> CreateAsync(Member member);
        Task<Member> ViewAsync(int id);
        Task<IEnumerable<Member>> ListAsync();
        Task<Member> UpdateAsync(Member member);
        Task<Member> DeleteAsync(int id);
    }
}
