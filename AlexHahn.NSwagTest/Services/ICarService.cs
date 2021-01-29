using System.Collections.Generic;
using AlexHahn.NSwagTest.DTOs;
using AlexHahn.NSwagTest.Models;

namespace AlexHahn.NSwagTest.Services
{
    public interface ICarService
    {
        IEnumerable<CarResponse> GetAll();
        void AddCar(CarRequest car);
    }
}