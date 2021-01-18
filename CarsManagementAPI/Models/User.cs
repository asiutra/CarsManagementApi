using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required, Range(18,99)]
        public int Age { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string Street { get; set; }
        public int ApartmentNumber { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
