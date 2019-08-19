using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace LoginReg
{
    public class User
    {
        [Key]
        public int UserId {get; set;}
        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName {get; set;}
        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password {get; set;}
        [NotMapped]
        [Compare("Password")]
        [Display(Name="Confirm Password")]
        [DataType(DataType.Password)]
        public string Confirm {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}