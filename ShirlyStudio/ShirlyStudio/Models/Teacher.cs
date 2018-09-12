using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{

    public enum Categories
    {
        [Display(Name = "חימר")]
        Clay,

        [Display(Name = "עיסת נייר")]
        Paper_mold,

        [Display(Name = "ציור")]
        Paint,

        [Display(Name = "פיוזינג")]
        Fusing
    }
    public class Teacher
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Catagory Catagory { get; set; }

    }
}
