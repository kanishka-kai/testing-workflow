using Microsoft.AspNetCore.Mvc;

namespace WizardsMindlessRavings1.Controllers
{
    public class ResourceHandlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
