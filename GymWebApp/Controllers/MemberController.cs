using Microsoft.AspNetCore.Mvc;

namespace GymWebApp.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> _members = new List<Member>()
        {
            new Member()
            {
                Id = 1,
                FirstName = "Max",
                LastName = "Silkou",
                Birthday = new DateTime(),
                IdCardNumber = "2342",
                Email = "masdf@gmalc",
                RegistrationDate = new DateTime(),
                IsDeleted = false,
            },
            new Member()
            {
                Id = 2,
                FirstName = "user",
                LastName = "bob",
                Birthday = new DateTime(),
                IdCardNumber = "2342",
                Email = "masdf@gmalc",
                RegistrationDate = new DateTime(),
                IsDeleted = false,
            }
        };

        public MemberController()
        {

        }

        [HttpGet]
        public IActionResult ListMembers()
        {
            return View("ListMembers", _members);
        }

        [HttpPost]
        public IActionResult AddMember(Member member)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetMember(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string IdCardNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
