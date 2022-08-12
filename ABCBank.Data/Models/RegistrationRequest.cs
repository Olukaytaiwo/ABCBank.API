using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class RegistrationRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BVN { get; set; }
        [Required]
        public string Address { get; set; }
       

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between at least 8 characters long", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
