using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace ShirlyStudio.Models
{
    public class WorkshopCategory
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Workshop Workshop { get; set; }

        public int CategoryId { get; set; }
        public int WorkshopId { get; set; }

    }
}
