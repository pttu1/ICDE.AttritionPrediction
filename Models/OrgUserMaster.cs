using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICDE.CompareProducts.Models
{
    public class OrgUserMaster
    {
        [Key]
        public int User_id { get; set; }
        [DisplayName("First name")]
        public string User_firstname { get; set; }
        [DisplayName("Last name")]
        public string User_lastname { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public System.DateTime User_DOB { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Marital Status")]
        public string Marita_Status { get; set; }

        [DisplayName("Working Years")]
        [DataType(DataType.Date)]
        public System.DateTime Working_Years { get; set; }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string User_email { get; set; }

        [DisplayName("Company Name")]
        public string Company_Fk_Name { get; set; }

        [DisplayName("Role id")]
        public int Role_Fk_id { get; set; }

        [DisplayName("Working At Company")]
        [DataType(DataType.Date)]
        public System.DateTime Years_At_Company { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [RegularExpression(@"^[a-zA-Z0-9\s]{8,15}$", ErrorMessage = "Please enter more than 8 characters\nSpecial Charaters not allowed")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        private DateTime _date = DateTime.Now;
        [DisplayName("Created Date")]
        public DateTime Create_date { get { return _date; } set { _date = value; } }

    }
}
