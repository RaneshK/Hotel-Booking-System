using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThreeSistersHotel.Pages.Administrator_Pages
{
    [Authorize(Roles = "administrators")]
    public class StatisticsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
