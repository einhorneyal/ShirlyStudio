using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public ICollection<Workshop> Workshop { get; set; }
        public Customer CustomerId { get; set; }
    }
}
