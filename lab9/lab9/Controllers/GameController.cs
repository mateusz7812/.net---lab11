
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace lab9.Controllers
{
    public class GameController : Controller
    {
        private readonly ILogger<GameController> _logger;
        private const int maxNumberDefault = 10;
        private const int tryNumberDefault = 0;

        private static int RandomNumber(int max)
        {
            return new Random().Next(max-1);
        }

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

        [Route("set,{n}")]
        public IActionResult Set(int n)
        {
            int maxNumber = HttpContext.Session.GetInt32("maxNumber") ?? maxNumberDefault;
            if(n > 0) 
                HttpContext.Session.SetInt32("maxNumber", n);
                maxNumber = n;
            HttpContext.Session.SetInt32("number", RandomNumber(maxNumber));
            ViewBag.maxNumber = maxNumber;
            return View();
        }

        [Route("draw")]
        public IActionResult Draw()
        {  
            int maxNumber = HttpContext.Session.GetInt32("maxNumber") ?? maxNumberDefault;
            HttpContext.Session.SetInt32("number", RandomNumber(maxNumber));
            ViewBag.maxNumber = maxNumber;
            HttpContext.Session.SetInt32("tryNumber", 0);
            return View();
        }

        [Route("guess,{n}")]
        public IActionResult Guess(int n)
        {
            int maxNumber = HttpContext.Session.GetInt32("maxNumber") ?? maxNumberDefault;
            int? number = HttpContext.Session.GetInt32("number");
            if(number is null){
                number = RandomNumber(maxNumber);
            }
            int tryNumber = HttpContext.Session.GetInt32("tryNumber") ?? 0;
            tryNumber++;
            HttpContext.Session.SetInt32("tryNumber", tryNumber);

            ViewBag.found = number == n;
            ViewBag.sectionClass = ViewBag.found ? "foundClass" : "missedClass";
           
            if(number == n){
                ViewBag.result = $"<h3>{n} jest poszukiwaną liczbą! Zgadłeś/aś za {tryNumber} próbą.</h3>";
            } else if (number > n){
                ViewBag.result = $"<h3>{n} jest mniejsza od poszukiwanej liczby. [0, {maxNumber}) ({tryNumber} próba)</h3>";
            } else if (number < n){
                ViewBag.result = $"<h3>{n} jest większa od poszukiwanej liczby.  [0, {maxNumber}) ({tryNumber} próba)</h3>";
            } else {
                ViewBag.result = $"<h3>Wystąpił problem z {n}, poszukiwaną liczbą była {number}</h3>";
            }
            return View();
        }
    }
}