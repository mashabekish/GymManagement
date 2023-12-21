using GymBusiness.Abstractions;
using GymDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GymWebApp.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _service;

        public SubscriptionController(ISubscriptionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> ListSubscriptionsAsync()
        {
            var subscriptions = await _service.ListAsync();
            return View("ListSubscriptions", subscriptions);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Subscription();
            return View("CreateSubscription", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Subscription subscription)
        {
            if (subscription is null)
            {
                return NotFound();
            }

            await _service.CreateAsync(subscription);
            return View("ApplyAdding");
        }
    }
}
