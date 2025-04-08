using Microsoft.AspNetCore.Mvc;

namespace Kurslar.Controllers
{

    public class OgrenciController : Controller
    {


        public IActionResult Create()
        {
            return View();
        }
    }
}
