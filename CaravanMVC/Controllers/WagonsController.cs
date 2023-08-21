using CaravanMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [Route("/wagons/{wagonId:int}")]
        public IActionResult Show(int wagonId)
        {
            var wagon = _context.Wagons.Where(w => w.Id == wagonId).Include(w => w.Passengers).First();
            return View(wagon);
        }
    }
}
