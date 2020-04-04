using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ICDE.CompareProducts.Models
{
    public class Login
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string User_email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DisplayName("Password")]
        [RegularExpression(@"^[a-zA-Z0-9\s]{8,15}$", ErrorMessage = "Please enter more than 8 character and special characters are not allowed")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

    }
}
