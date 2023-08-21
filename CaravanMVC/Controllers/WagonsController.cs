using CaravanMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace CaravanMVC.Controllers
{
    public class WagonsController : Controller
    {
        private readonly CaravanMvcContext _context;
        
        public WagonsController(CaravanMvcContext context)
        {
            _context = context;
        }

        [Route("/wagons")]
        public IActionResult Index()
        {
            var allWagons = _context.Wagons.ToList();
            return View(allWagons);
        }
    }
}
