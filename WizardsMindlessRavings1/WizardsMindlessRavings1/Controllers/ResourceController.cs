using Microsoft.AspNetCore.Mvc;

namespace WizardsMindlessRavings1.Controllers
{
    public class ResourceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
