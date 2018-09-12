using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Workshop
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Catagory Catagory { get; set; }
        public Teacher Teacher { get; set; }
        public int MyProperty { get; set; }
        public DateTime Time { get; set; }
        public int Available_Members { get; set; }
        public String Description { get; set; }


    }
}
