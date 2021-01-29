using System;

namespace AlexHahn.NSwagTest.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Features[] Features { get; set; }
    }
}