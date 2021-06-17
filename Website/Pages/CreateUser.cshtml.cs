using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ModelLibrary;
using Newtonsoft.Json;

namespace Website.Pages
{
    public class CreateUserModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
