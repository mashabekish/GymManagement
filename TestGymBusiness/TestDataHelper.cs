using GymDomain.Entities;

namespace Library.BusinessLogicTest;

public static class TestDataHelper
{
    public static Task<IEnumerable<Member>> GetFakeMembers()
    {
        var members = new List<Member>()
        {
            new() {
                Id = 1,
                FirstName = "FirstName1",
                LastName = "LastName1",
                Birthday = DateTime.Now,
                IdCardNumber = Guid.NewGuid(),
                Email = "Email1",
                RegistrationDate = DateTime.Now,
                IsDeleted = false
            }
        };
        return Task.FromResult(members.AsEnumerable());
    }
}
