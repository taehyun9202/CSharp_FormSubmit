using System.ComponentModel.DataAnnotations;

namespace FormSubmit.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First name:")] 
        public string FirstName {get;set;}

        [Required]
        [MinLength(4)]
        [Display(Name = "Last name:")] 
        public string LastName {get;set;}

        [Required]
        [Range(0,100)]
        public int Age {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}