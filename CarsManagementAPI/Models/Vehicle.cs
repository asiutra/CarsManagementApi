using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarsManagementAPI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int HorsePower { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        public int UserId { get; set; }
        public ICollection<Service> Services { get; set; }
        
    }
}