
namespace GymDomain.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Guid IdCardNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
