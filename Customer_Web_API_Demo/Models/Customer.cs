using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Web_API_Demo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        
    }
}
