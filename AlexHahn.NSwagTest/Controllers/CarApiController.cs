using System;
using AlexHahn.NSwagTest.DTOs;
using AlexHahn.NSwagTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlexHahn.NSwagTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarApiController : Controller
    {
        private readonly ICarService _carService;

        public CarApiController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public bool Create(CarRequest car)
        {
            try
            {
                _carService.AddCar(car);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        [HttpGet]
        public ActionResult<CarResponse[]> GetAll()
        {
            var cars = _carService.GetAll();
            return Json(cars);
        }
    }
}