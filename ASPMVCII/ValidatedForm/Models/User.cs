using System;
using System.ComponentModel.DataAnnotations;

namespace ValidatedForm.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [Required]
        [MinLength(4)]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [Range(1,Int32.MaxValue)]
        [Display(Name = "Age")]
        public int Age {get; set;}

        [Required]
        [EmailAddress]
        [DataType(DataType.Text)]
        [Display(Name = "Email Address")]
        public string Email {get; set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password {get; set;}
    }
}