using System.ComponentModel.DataAnnotations;
using System;

namespace BankAccount.Models
{
    public class Transaction
    {
        [Key]
        public int TransId {get; set;}
        [Required]
        public double Amount {get; set;}
        public int UserId {get; set;}
        public User Account {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
    }
}