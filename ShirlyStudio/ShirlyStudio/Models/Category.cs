﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShirlyStudio.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "שם קטגוריה")]
        public String Name { get; set; }
        public ICollection<WorkshopCategory> WorkshopCategory { get; set; }
    }
}
