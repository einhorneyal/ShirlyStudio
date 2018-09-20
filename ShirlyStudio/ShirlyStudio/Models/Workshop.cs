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

        [Required]
        [Display(Name="שם סדנא")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "קטגוריה")]
        public ICollection<WorkshopCategory> WorkshopCategory { get; set; }

        [Required]
        [Display(Name = "תאריך הסדנא")]
        public DateTime FullData { get; set; }

        [Required]
        [Display(Name = "מחיר הסדנא")]
        public int Price { get; set; }

        [Required]
        [Display (Name= "מספר מקומות פנויים")]
        public int Available_Members { get; set; }

        [Display(Name = "פרטים נוספים")]
        public String Description { get; set; }

        [Display(Name = "שם המורה")]
        public Teacher TeacherId { get; set; }

        public Transaction TransactionId { get; set; }
    }
}
