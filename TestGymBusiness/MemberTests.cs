using GymBusiness.Abstractions;
using GymBusiness.Services;
using GymDomain.Abstractions;
using Library.BusinessLogicTest;
using Moq;

namespace TestGymBusiness
{
    public class MemberTests
    {
        private IMemberService _service;

        [SetUp]
        public void Setup()
        {
            var members = TestDataHelper.GetFakeMembers();

            var repositoryMock = new Mock<IMemberRepository>();
            repositoryMock.Setup(m => m.ListAsync()).Returns(members);

            _service = new MemberService(repositoryMock.Object);
        }

        [TestCase(1)]
        public async Task ListTestAsync(int count)
        {
            var books = await _service.ListAsync();
            Assert.That(count, Is.EqualTo(books.Count()));
        }
    }
}
