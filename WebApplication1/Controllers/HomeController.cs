using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()

        {


            List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m },
            new Product { Id = 2, Name = "Smartphone", Price = 699.99m },
            new Product { Id = 3, Name = "Tablet", Price = 399.99m },
            new Product { Id = 4, Name = "Monitor", Price = 199.99m },
            new Product { Id = 5, Name = "Keyboard", Price = 49.99m },
            new Product { Id = 6, Name = "Mouse", Price = 29.99m },
            new Product { Id = 7, Name = "Printer", Price = 149.99m },
            new Product { Id = 8, Name = "Webcam", Price = 89.99m },
            new Product { Id = 9, Name = "Speaker", Price = 59.99m },
            new Product { Id = 10, Name = "Headphones", Price = 79.99m }
        };


            /*ViewBag.productList = products;*/

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult User(int id)
        {
            var user = new[]
            {
                new {Id=1, Name="Nghia"},
                new {Id=2,  Name="Tu"},
            };
            string Name = null;
            foreach (var item in user)
            {
                if(item.Id == id)
                {
                    Name = item.Name;
                }
            }
            return Content(Name, "text/plain");
        }
      
    }
}
