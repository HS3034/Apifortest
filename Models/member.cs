using System;
using System.ComponentModel.DataAnnotations;

namespace Apifortest.Models
{
    public class Member
    {
        
        [Key]
        public int Mid {get;set;}
        public string Name{get;set;}
        public string Password{get;set;}
        public string Email{get;set;}
        public DateTime? Brithday{get;set;} 
        public DateTime? stamtime{get;set;}
        
    }
}