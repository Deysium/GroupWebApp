using System.ComponentModel.DataAnnotations;

namespace GroupWebApp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; } 
        public int State { get; set; }
    }
}
