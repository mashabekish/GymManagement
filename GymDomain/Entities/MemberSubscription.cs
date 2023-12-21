
namespace GymDomain.Entities
{
    public class MemberSubscription
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int SubscriptionId { get; set; }
        public int OriginalPrice { get; set; }
        public int DiscountValue { get; set; }
        public int PaidPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RemainingSessions { get; set; }
        public bool IsDeleted { get; set; }
    }
}
