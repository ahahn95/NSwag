using AlexHahn.NSwagTest.DTOs;
using AlexHahn.NSwagTest.Models;
using AutoMapper;

namespace AlexHahn.NSwagTest.Mappers
{
    public class ModelToCarResponse
    {
        public static CarResponse Map(Car carRequest)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Car, CarResponse>(); });

            var mapper = config.CreateMapper();
            return mapper.Map<Car, CarResponse>(carRequest);
        }
    }
}