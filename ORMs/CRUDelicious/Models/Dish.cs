using System.ComponentModel.DataAnnotations;
using System;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}
        [Required]
        [MinLength(2)]
        [Display(Name = "Name of Dish")]
        public string Name {get; set;}
        [Required]
        [MinLength(2)]
        [Display(Name = "Chef's Name")]
        public string Chef {get; set;}
        [Required]
        [Range(1,5)]
        public int Tastiness {get; set;}
        [Required]
        [Display(Name = "# of Calories")]
        [Range(1,Int32.MaxValue)]
        public int Calories {get; set;}
        [Required]
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}