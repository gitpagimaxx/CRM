using Microsoft.AspNetCore.Mvc;

namespace CRM.Api.Controllers
{
    public class TokenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
