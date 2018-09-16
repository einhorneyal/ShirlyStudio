using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{


    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "שם מלא")]
        public String Name { get; set; }

        [Display(Name = "סדנאות")]
        public ICollection<Workshop> Workshops { get; set; }
    }
}
