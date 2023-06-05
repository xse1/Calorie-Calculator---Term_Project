using Calorie_Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calorie_Calculator.Controllers
{
    public class PedometerController : Controller
    {
        private Steps_dContext _Steps_dContext;
        public PedometerController (Steps_dContext steps_DContext)
        {
            _Steps_dContext = steps_DContext;

        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }


        [HttpPost]
        public IActionResult StepsToCalories(Steps_d TotalCaloriesBurned)
        {
            TotalCaloriesBurned.Hist = DateTime.Now;
            _Steps_dContext.Steps_Ds.Add(TotalCaloriesBurned);
            _Steps_dContext.SaveChanges();
            return View(TotalCaloriesBurned);
        }
    }
}
