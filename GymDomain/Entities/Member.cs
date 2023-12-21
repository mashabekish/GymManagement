using System.ComponentModel.DataAnnotations;

namespace GymDomain.Entities
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public Guid IdCardNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsDeleted { get; set; }

        public List<MemberSubscription> Subscriptions { get; set; }
    }
}
