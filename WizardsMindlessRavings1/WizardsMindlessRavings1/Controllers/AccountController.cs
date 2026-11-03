using Microsoft.AspNetCore.Mvc;

namespace WizardsMindlessRavings1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
