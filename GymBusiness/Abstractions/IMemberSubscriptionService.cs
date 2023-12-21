using GymDomain.Entities;

namespace GymBusiness.Abstractions
{
    public interface IMemberSubscriptionService
    {
        Task<MemberSubscription> CreateAsync(MemberSubscription subscription);
        Task<MemberSubscription> ViewAsync(int id);
        Task<IEnumerable<MemberSubscription>> ListAsync();
        Task<MemberSubscription> UpdateAsync(MemberSubscription subscription);
        Task<MemberSubscription> DeleteAsync(int id);
    }
}
