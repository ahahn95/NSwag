using AlexHahn.NSwagTest.DTOs;
using AlexHahn.NSwagTest.Models;
using AutoMapper;

namespace AlexHahn.NSwagTest.Mappers
{
    public static class CarRequestToModel
    {
        public static Car Map(CarRequest carRequest)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<CarRequest, Car>(); });

            var mapper = config.CreateMapper();
            return mapper.Map<CarRequest, Car>(carRequest);
        }
    }
}