using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Website.Services.Base
{
    public class BaseService 
    {
        protected readonly string ApiIP;

        public BaseService(IConfiguration configuration)
        {
            ApiIP = configuration["IP:API"];
        }
    }
}
