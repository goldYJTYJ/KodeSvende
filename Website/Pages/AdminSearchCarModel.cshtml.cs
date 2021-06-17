using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    [Authorize(Roles = "Administrator")]
    public class AdminSearchCarModelModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
