using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThreeSistersHotel.Pages.Models
{
    public class Booking
    {
        [Key]
        public int ID { get; set; }
        public int RoomID { get; set; }
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Check In date is needed")]
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Check Out date is needed")]
        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }

        public decimal Cost { get; set; }
        public Room TheRoom { get; set; }
        public Customer TheCustomer { get; set; }
    }
}
