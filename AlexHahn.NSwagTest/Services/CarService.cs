using System;
using System.Collections.Generic;
using System.Linq;
using AlexHahn.NSwagTest.DTOs;
using AlexHahn.NSwagTest.Mappers;
using AlexHahn.NSwagTest.Models;

namespace AlexHahn.NSwagTest.Services
{
    public class CarService : ICarService
    {
        private readonly IDictionary<Guid, Car> _db;

        public CarService()
        {
            _db = new Dictionary<Guid, Car>();
        }

        public IEnumerable<CarResponse> GetAll()
        {
            var carResponses = _db.Values.Select(ModelToCarResponse.Map);
            return carResponses;
        }

        public void AddCar(CarRequest carRequest)
        {
            var car = CarRequestToModel.Map(carRequest);
            var guid = Guid.NewGuid();
            car.Id = guid;
            _db.Add(car.Id, car);
        }
    }
}