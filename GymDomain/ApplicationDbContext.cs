using GymDomain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymDomain
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberSubscription> MemberSubscriptions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var members = new List<Member>
            {
                new()
                {
                    Id = 1,
                    FirstName = "Maksim",
                    LastName = "Silkou",
                    Birthday = DateTime.Now,
                    IdCardNumber = Guid.NewGuid(),
                    Email = "Maksim.Silkou@gmail.com",
                    RegistrationDate = DateTime.Now,
                    IsDeleted = false,
                },
                new()
                {
                    Id = 2,
                    FirstName = "Maria",
                    LastName = "Bekish",
                    Birthday = DateTime.Now,
                    IdCardNumber = Guid.NewGuid(),
                    Email = "Maria.Bekish@gmail.com",
                    RegistrationDate = DateTime.Now,
                    IsDeleted = false,
                },
                new()
                {
                    Id = 3,
                    FirstName = "Alex",
                    LastName = "Khartaniuk",
                    Birthday = DateTime.Now,
                    IdCardNumber = Guid.NewGuid(),
                    Email = "Alex.Khartaniuk@gmail.com",
                    RegistrationDate = DateTime.Now,
                    IsDeleted = false,
                }
            };
            builder.Entity<Member>().HasData(members);

            var subscriptions = new List<Subscription>
            {
                new()
                {
                    Id = 1,
                    Code = Guid.NewGuid(),
                    Desrciption = "Desrciption",
                    NumberOfMonths = 12,
                    WeekFrequency = WeekFrequency.TwoDays,
                    TotalNumberOfSessions = 8,
                    TotalPrice = 100,
                    IsDeleted = false
                },
                new()
                {
                    Id = 2,
                    Code = Guid.NewGuid(),
                    Desrciption = "Desrciption",
                    NumberOfMonths = 11,
                    WeekFrequency = WeekFrequency.ThreeDays,
                    TotalNumberOfSessions = 12,
                    TotalPrice = 140,
                    IsDeleted = false
                },
                new()
                {
                    Id = 3,
                    Code = Guid.NewGuid(),
                    Desrciption = "Desrciption",
                    NumberOfMonths = 10,
                    WeekFrequency = WeekFrequency.FourDays,
                    TotalNumberOfSessions = 16,
                    TotalPrice = 180,
                    IsDeleted = false
                }
            };
            builder.Entity<Subscription>().HasData(subscriptions);

            var memberSubscriptions = new List<MemberSubscription>
            {
                new()
                {
                    Id = 1,
                    MemberId = 1,
                    SubscriptionId = 1,
                    OriginalPrice = 100,
                    DiscountValue = 0,
                    PaidPrice = 100,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(30),
                    RemainingSessions = 8,
                    IsDeleted = false
                },
                new()
                {
                    Id = 2,
                    MemberId = 2,
                    SubscriptionId = 2,
                    OriginalPrice = 140,
                    DiscountValue = 0,
                    PaidPrice = 140,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(30),
                    RemainingSessions = 12,
                    IsDeleted = false
                },
                new()
                {
                    Id = 3,
                    MemberId = 3,
                    SubscriptionId = 3,
                    OriginalPrice = 180,
                    DiscountValue = 0,
                    PaidPrice = 180,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(30),
                    RemainingSessions = 16,
                    IsDeleted = false
                }
            };
            builder.Entity<MemberSubscription>().HasData(memberSubscriptions);
        }
    }
}
