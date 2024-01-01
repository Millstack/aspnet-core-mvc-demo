using Microsoft.AspNetCore.Mvc;

namespace Election_PMS.Controllers
{
    public class AdminTagController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
