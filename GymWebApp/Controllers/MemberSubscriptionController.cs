using GymBusiness.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace GymWebApp.Controllers
{
    public class MemberSubscriptionController : Controller
    {
        private readonly IMemberSubscriptionService _service;

        public MemberSubscriptionController(IMemberSubscriptionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var subscriptions = await _service.ListAsync();
            return View("List", subscriptions);
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    var model = new Subscription();
        //    return View("CreateSubscription", model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(Subscription subscription)
        //{
        //    if (subscription is null)
        //    {
        //        return NotFound();
        //    }

        //    await _service.CreateAsync(subscription);
        //    return View("ApplyAdding");
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //[HttpGet]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    await _service.DeleteAsync(id);

        //    var subscriptions = await _service.ListAsync();
        //    return View("ListSubscriptions", subscriptions);
        //}
    }
}
