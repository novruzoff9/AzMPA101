using logis.Data;
using logis.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace logis.Controllers
{
    public class HomeController(AppDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var data = context.Services.ToList();
            HomeVM homeVM = new()
            {
                Services = data
            };
            return View(homeVM);
        }
    }
}
