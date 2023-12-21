using GymBusiness.Abstractions;
using GymDomain.Entities;
using GymWebApp.Models.Member;
using Microsoft.AspNetCore.Mvc;

namespace GymWebApp.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public async Task<IActionResult> ListMembers()
        {
            var members = await _memberService.ListAsync();

            var membersViewModel = new List<MemberViewModel>();

            foreach (var member in members)
            {
                membersViewModel.Add(new MemberViewModel
                {
                    Id = member.Id,
                    Birthday = member.Birthday,
                    Email = member.Email,
                    FirstName = member.FirstName,
                    LastName = member.LastName,
                    IdCardNumber = member.IdCardNumber.ToString(),
                    IsDeleted = member.IsDeleted,
                    RegistrationDate = member.RegistrationDate,
                });
            }

            return View("ListMembers", membersViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new AddMemberViewModel();
            return View("CreateMember", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddMemberViewModel modelViewModel)
        {
            if (modelViewModel is null)
            {
                return NotFound();
            }

            var model = new Member()
            {
                FirstName = modelViewModel.FirstName,
                LastName = modelViewModel.LastName,
                Birthday = modelViewModel.Birthday,
                Email = modelViewModel.Email,
            };

            await _memberService.CreateAsync(model);

            return View("ApplyAdding");
        }

        [HttpGet("{id}")]
        public IActionResult GetMember(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _memberService.DeleteAsync(id);

            return await ListMembers();
        }
    }
}
