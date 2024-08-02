using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThreeSistersHotel.Pages.Customers
{
    [Authorize(Roles = "customers")]
    public class SearchRoomsModel : PageModel
    {
        //String query = "SELECT * FROM ROOM WHERE";

        public void OnGet()
        {
        }
    }
}
