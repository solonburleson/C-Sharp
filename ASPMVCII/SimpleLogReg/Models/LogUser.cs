using System.ComponentModel.DataAnnotations;

namespace SimpleLogReg.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LogEmail {get; set;}

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string LogPassword {get; set;}
    }
}