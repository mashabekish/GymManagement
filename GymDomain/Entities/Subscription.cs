
namespace GymDomain.Entities
{
    public class Subscription
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        public string Desrciption { get; set; }
        public int NumberOfMonths { get; set; }
        public enum WeekFrequency {twoDays, threeDays, fourDays, fiveDays}
        public int TotalNumberOfSessions { get; set; }
        public int TotalPrice { get; set; }
        public bool IsDeleted { get; set; }
    }
}
