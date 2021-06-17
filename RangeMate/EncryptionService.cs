using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class EncryptionService 
    {

        private readonly IDataProtectionProvider _dataProtectionProvider;
        private readonly IConfiguration _configuration;

        public EncryptionService(IDataProtectionProvider dataProtectionProvider, IConfiguration configuration)
        {
            _dataProtectionProvider = dataProtectionProvider;
            _configuration = configuration;
        }

        // Encrypts a string
        public string Encrypt(string input)
        {
            var protector = _dataProtectionProvider.CreateProtector(_configuration.GetValue<string>("EncrytionKeys"));
            return protector.Protect(input);
        }

        // Decrypts a string
        public string Decrypt(string input)
        {
            var protector = _dataProtectionProvider.CreateProtector(_configuration.GetValue<string>("EncrytionKeys"));
            return protector.Unprotect(input);
        }
    }
}
