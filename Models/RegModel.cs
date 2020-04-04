using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICDE.CompareProducts.Models
{
    public class RegModel
    {
        [Key]
        public int User_id { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        [DisplayName("First name")]
        public string User_firstname { get; set; }

        [DisplayName("Last name")]
        [Required(ErrorMessage = "Please enter last name")]
        public string User_lastname { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string User_email { get; set; }

        [DisplayName("Company")]
        public string Company_Fk_Name { get; set; }
        [DisplayName("Role")]
        public int Role_Fk_id { get; set; }
        [DisplayName("Years At Company")]
        [DataType(DataType.Date)]
        public System.DateTime Years_At_Company { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DisplayName("Password")]
        [RegularExpression(@"^[a-zA-Z0-9\s]{8,15}$", ErrorMessage = "Please enter more than 8 character and special characters are not allowed")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Compare("Password", ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public String ConfirmPassword { get; set; }
        
    }
}
