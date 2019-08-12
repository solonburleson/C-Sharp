using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quotes
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Name")]
        public string Name {get; set;}

        [Required]
        [Display(Name = "Quote")]
        public string Quote {get; set;}
    }
}