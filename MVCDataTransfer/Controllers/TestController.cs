using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ViewResult Index1()
        {
            return View();
        }
        public ViewResult Display1()
        {
            return View();
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            return View();
        }
        public ViewResult Display2()
        {
            return View();
        }
        public ViewResult Index4()
        {
            return View();
        }
        public ViewResult Index5(int? id, string name, double? price)
        {
            var product = new { Id = id, Name = name, Price = price };
            return View(product);
        }
    }
}