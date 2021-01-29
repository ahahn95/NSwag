using System;
using AlexHahn.NSwagTest.Models;

namespace AlexHahn.NSwagTest.DTOs
{
    public class CarResponse
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Features[] Features { get; set; } 
    }
}