using ShirlyStudio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
 
    public class Workshop
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<WorkshopCategory> WorkshopCategory { get; set; }
        public DateTime FullData { get; set; }
        public int Price { get; set; }

        [Display (Name= "Number of available seats")]
        public int Available_Members { get; set; }
        public String Description { get; set; }


        public Teacher TeacherId { get; set; }

        public Transaction TransactionId { get; set; }
    }
}
