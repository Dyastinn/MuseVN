using Microsoft.AspNetCore.Mvc;

namespace MuseVNWeb.Controllers{
    public class CategoryController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}
