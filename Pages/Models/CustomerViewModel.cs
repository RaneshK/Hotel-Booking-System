using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThreeSistersHotel.Pages.Models
{
    public class CustomerViewModel
    {
       
        [Required(ErrorMessage = "Your Surname is required")]
        [RegularExpression(@"^[A-Za-z'-]{2,20}$", ErrorMessage = "have to be 2 to 20 characters and only consists of English letters, hyphen andapostrophe.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Your Given Name is required")]
        [RegularExpression(@"^[A-Za-z'-]{2,20}$", ErrorMessage = "have to be 2 to 20 characters and only consists of English letters, hyphen andapostrophe.")]
        public string GivenName { get; set; }

        [Required(ErrorMessage = "Poscode can not be empty")]
        [RegularExpression(@"^[0-9]{4}", ErrorMessage = "should only consist 4 digits")]
        public string Postcode { get; set; }
    }
}
