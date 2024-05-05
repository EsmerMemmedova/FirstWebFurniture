using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
