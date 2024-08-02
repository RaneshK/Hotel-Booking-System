using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThreeSistersHotel.Pages.Models
{
    public class Room
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Level is mandatory")]
        [RegularExpression(@"^[G1-3]$", ErrorMessage = "The levels can only be either 'G' or 1,2 and 3")]
        public string Level { get; set; }


        [Required(ErrorMessage = "Bed Count is mandatory")]
        [RegularExpression(@"^[1-3]$", ErrorMessage = "The number of beds in the room can only be 1,2 or 3")]
        public int BedCount { get; set; }


        [Required(ErrorMessage = "Price is mandatory and has to in between 50 to 300")]
        [Range(50, 300)]
        public decimal Price { get; set; }

        public ICollection<Booking> TheBookings { get; set; }


    }
}
