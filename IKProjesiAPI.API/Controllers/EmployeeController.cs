using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
