using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public String Customer_name { get; set; }
        public String Workshop_name { get; set; }
        public Double Price { get; set; }
    }
}
