using System.ComponentModel.DataAnnotations;
using AlexHahn.NSwagTest.Models;

namespace AlexHahn.NSwagTest.DTOs
{
    public class CarRequest
    {
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        
        public Features[] Features { get; set; }
    }
}