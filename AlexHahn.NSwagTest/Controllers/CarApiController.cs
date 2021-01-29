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
        public IActionResult Create(CarRequest car)
        {
            _carService.AddCar(car);
            return Ok();
        }

        [HttpGet]
        public ActionResult<CarResponse[]> GetAll()
        {
            var cars = _carService.GetAll();
            return Json(cars);
        }
    }
}