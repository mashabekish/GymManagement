using GymDomain.Entities;

namespace GymDomain.Abstractions
{
    public interface IMemberSubscriptionRepository
    {
        Task<MemberSubscription> ViewAsync(int code);
        Task<MemberSubscription> AddMemberSubAsync(MemberSubscription memberSub);
        Task<IEnumerable<MemberSubscription>> ListAsync();
        Task<MemberSubscription> UpdateMemberSubAsync(MemberSubscription memberSub);
        Task<MemberSubscription> DeleteMemberSubAsync(int id);
    }
}
