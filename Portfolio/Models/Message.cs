using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Message
    {
       
        [Required(ErrorMessage = "Please enter your email.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Your Email Address:")]
        public string Email { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Comments:")]
        public string ExtraComment { get; set; }
    }
}
