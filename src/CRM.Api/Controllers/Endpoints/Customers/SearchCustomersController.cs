using Microsoft.AspNetCore.Mvc;

namespace CRM.Api.Controllers.Endpoints.Customers
{
    public class SearchCustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
