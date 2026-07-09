using Microsoft.AspNetCore.Mvc;

namespace TravelEU.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}