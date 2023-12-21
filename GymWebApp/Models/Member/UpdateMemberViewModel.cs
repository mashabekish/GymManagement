namespace GymWebApp.Models.Member
{
    public class UpdateMemberViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string IdCardNumber { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
