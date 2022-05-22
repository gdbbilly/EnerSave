using Microsoft.AspNetCore.Mvc;

namespace EnerSave.Controllers
{
    public class GastosGeraisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
