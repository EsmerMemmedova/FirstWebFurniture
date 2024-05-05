using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture = new Furniture()
            {
                Id = 1,
                Name = "Chair01",
                Price = 100
            };
            Furniture furniture1 = new Furniture()
            {
                Id = 2,
                Name="Chair02",
                Price = 100

            };
            Furniture furniture2 = new Furniture()
            {
              Id= 3,
              Name="Table",
              Price = 100
            };
            List<Furniture> furnitures = new List<Furniture>();
            furnitures.Add(furniture);
            ViewBag.Data = furniture;

            return View();
        }
    }
}
