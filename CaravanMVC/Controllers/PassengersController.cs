using CaravanMVC.DataAccess;
using CaravanMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaravanMVC.Controllers
{
    public class PassengersController : Controller
    {
        private readonly CaravanMvcContext _context;

        public PassengersController(CaravanMvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("/wagons/{wagonId:int}/passengers/new")]
        public IActionResult New(int wagonId)
        {
            var wagon = _context.Wagons.Find(wagonId);
            return View(wagon);
        }

        [HttpPost]
        [Route("/wagons/{wagonId:int}/passengers/new")]
        public IActionResult Create(int wagonId, Passenger passenger)
        {
            var wagon = _context.Wagons.Find(wagonId);
            wagon.Passengers.Add(passenger);
            _context.SaveChanges();

            return Redirect($"/wagons/{wagonId}");
        }
    }
}
