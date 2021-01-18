using System;
using System.ComponentModel.DataAnnotations;

namespace CarsManagementAPI.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string What { get; set; }
        [Required]
        public string Where { get; set; }
        public DateTime When { get; set; }
        [Required]
        public double Price { get; set; }
        public int VehicleId { get; set; }
    }
}