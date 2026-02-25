using Microsoft.AspNetCore.Mvc;

namespace CRM.Api.Controllers.Endpoints.Customers
{
    public class GetCustomerEventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
