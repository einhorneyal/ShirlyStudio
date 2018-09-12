using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public String Email { get; set; }

        [Display(Name = "Phone number")]
        public String PhoneNumber { get; set; }


        public ICollection<Transaction> Transaction { get; set; }
    }
}
