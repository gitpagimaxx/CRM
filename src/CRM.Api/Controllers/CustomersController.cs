using Microsoft.AspNetCore.Mvc;

namespace CRM.Api.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
