using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
