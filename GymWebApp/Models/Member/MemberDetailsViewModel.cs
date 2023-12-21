using GymWebApp.Models.MemberSubscription;

namespace GymWebApp.Models.Member
{
    public class MemberDetailsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string IdCardNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<MemberSubscriptionViewModel> MemberSubscriptions { get; set; }
    }
}
