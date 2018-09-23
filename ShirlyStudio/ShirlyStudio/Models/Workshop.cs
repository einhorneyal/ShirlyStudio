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
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="שם סדנה")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "קטגוריה")]
        public ICollection<WorkshopCategory> WorkshopCategory { get; set; }

        [Required]
        [Display(Name = "תאריך הסדנה")]
        public DateTime FullData { get; set; }

        [Required]
        [Display(Name = "מחיר הסדנה")]
        public int Price { get; set; }

        [Required]
        [Display (Name= "מספר מקומות פנויים")]
        public int Available_Members { get; set; }

        [Display(Name = "פרטים נוספים")]
        public String Description { get; set; }

        [Display(Name = "שם המורה")]
        public Teacher TeacherId { get; set; }

        [Display(Name = "משך הסדנה")]
        public double Duration { get; set; }

        [Display(Name = "מספר עסקה")]
        public Transaction TransactionId { get; set; }
    }
}
