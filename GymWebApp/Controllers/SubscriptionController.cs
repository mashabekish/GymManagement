using Microsoft.AspNetCore.Mvc;

namespace GymWebApp.Controllers
{
    public class SubscriptionController : Controller
    {
        public SubscriptionController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
