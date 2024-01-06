using Microsoft.AspNetCore.Mvc;

namespace BloodCenter.Mvc.Controllers
{
    public class KanTalepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
