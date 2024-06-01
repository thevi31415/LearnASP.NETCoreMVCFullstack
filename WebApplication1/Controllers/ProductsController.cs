using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Products = new[]
     {
        new { idP = 1, Name = "Nguyen Van A" },
        new { idP = 2, Name = "Nguyen Van B" },
        new { idP = 3, Name = "Nguyen Van C" }
    };
            string NameP = "";
            foreach (var product in Products)
            {
                if(product.idP == id)
                {
                    NameP= product.Name;
                }
            }
            ViewBag.ProName = NameP;
            return View();
        }

    }
}

