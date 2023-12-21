using System.ComponentModel.DataAnnotations;

namespace GymDomain.Entities
{
    public enum WeekFrequency 
    { 
        twoDays, 
        threeDays, 
        fourDays, 
        fiveDays 
    }

    public class Subscription
    {
        public int Id { get; set; }

        public Guid Code { get; set; }

        [MaxLength(255)]
        public string Desrciption { get; set; }

        public int NumberOfMonths { get; set; }

        public WeekFrequency WeekFrequency { get; set; }

        public int TotalNumberOfSessions { get; set; }

        public int TotalPrice { get; set; }

        public bool IsDeleted { get; set; }

        public List<MemberSubscription> Members { get; set; }
    }
}
