using Microsoft.AspNetCore.Mvc;

namespace GymWebApp.Controllers
{
    public class MemberSubscriptionController : Controller
    {
        public MemberSubscriptionController()
        { 

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
