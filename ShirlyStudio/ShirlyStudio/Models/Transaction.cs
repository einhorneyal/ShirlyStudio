using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "סדנאות")]
        public ICollection<Workshop> Workshop { get; set; }

        [Display(Name = "לקוח")]
        public Customer CustomerId { get; set; }
    }
}
