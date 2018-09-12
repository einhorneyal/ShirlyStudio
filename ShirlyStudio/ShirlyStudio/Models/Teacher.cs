using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{


    public class Teacher
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Workshop> Workshops { get; set; }
    }
}
