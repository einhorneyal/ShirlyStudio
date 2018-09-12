using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShirlyStudio.Models
{
    public class Category
    {
        //chack
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<WorkshopCategory> WorkshopCategory { get; set; }
    }
}
