using System.ComponentModel.DataAnnotations;
using System;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}
        [MinLength(2)]
        public string Name {get; set;}
        public int Calories {get; set;}
        public int Tastiness {get; set;}
        [MinLength(8)]
        public string Description {get; set;}
        public int ChefId {get; set;}
        public Chef Creator {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}