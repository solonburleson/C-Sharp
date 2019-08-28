using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB {get; set;}
        public List<Dish> CreatedDishes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}