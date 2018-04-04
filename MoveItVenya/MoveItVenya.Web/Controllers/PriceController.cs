using MoveItVenya.Logic;
using System.Web.Mvc;

namespace MoveItVenya.Web.Controllers
{
    public class PriceController : Controller
    {
        private IPriceService _priceService;


        public PriceController()
        {
            _priceService = new PriceService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CalculatePrice(double livingArea, double atticArea, double distance)
        {
            var result = _priceService.Calculate(livingArea, atticArea, distance);

            return View("CalculatePriceResult", result);
        }
    }
}