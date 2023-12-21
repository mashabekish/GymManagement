using GymBusiness.Abstractions;
using GymDomain.Entities;
using GymWebApp.Models.Member;
using GymWebApp.Models.MemberSubscription;
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
                    IdCardNumber = member.IdCardNumber.ToString()
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
        public async Task<IActionResult> MemberDetails(int id)
        {
            var member = await _memberService.ViewAsync(id);
            
            if (member is null)
            {
                return NotFound();
            }

            var memberViewModel = new MemberDetailsViewModel()
            {
                Id = member.Id,
                FirstName = member.FirstName,
                LastName = member.LastName,
                Birthday = member.Birthday,
                Email = member.Email,
                IdCardNumber = member.IdCardNumber.ToString(),
                IsDeleted = member.IsDeleted,
                MemberSubscriptions = new List<MemberSubscriptionViewModel>(),
                RegistrationDate = member.RegistrationDate,
            };

            return View("MemberDetailsDescription", memberViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var member = await _memberService.ViewAsync(id);

            if (member is null)
            {
                return NotFound();
            }

            var memberViewModel = new MemberDetailsViewModel()
            {
                Id= member.Id,
                FirstName = member.FirstName,
                IdCardNumber = member.IdCardNumber.ToString(),
                Birthday = member.Birthday,
                Email = member.Email,
                IsDeleted = member.IsDeleted,
                LastName = member.LastName,
                RegistrationDate = member.RegistrationDate
            };

            return View("EditMember", memberViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateMemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                var memberEntity = new Member()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Birthday = model.Birthday,
                    Email = model.Email,
                    IsDeleted = model.IsDeleted,
                    IdCardNumber = Guid.Parse(model.IdCardNumber)
                };

                await _memberService.UpdateAsync(memberEntity);
            }

            return RedirectToAction("ListMembers");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _memberService.DeleteAsync(id);

            return await ListMembers();
        }
    }
}
