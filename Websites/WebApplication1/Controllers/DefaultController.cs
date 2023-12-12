using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        //url- /Default/Index/10?a=10&b=20&c=30
        //url- /Default/Index/10?b=20
        //url- /Default/Index/10?a=10&b=20&c=30
        //url- /Default/Index/10?a=10c=30
        public IActionResult Index(int? id,int a=1,int b=2,int c=3)
        {
            //if(id == null)
            //    return NotFound();
            ViewBag.id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;
            return View();
        }
        public IActionResult View1()
        {
           
            return View("Index1");
        }
        public IActionResult View2()
        {

            return View();
        }
        public IActionResult View3()
        {

            return View();
        }
        public IActionResult View4()
        {

            return View();
        }
        public IActionResult View5()
        {

            return View();
        }
    }
}
