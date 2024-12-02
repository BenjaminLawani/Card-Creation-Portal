using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Transfer
{
    public class CardUpdateDto
    {
        public string? CardName { get; set; }
        public int? CardPin { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? CountryCode { get; set; }
        public string? PrimaryMobileCountryCode { get; set; }
        public string? PrimaryMobileNumber { get; set; }
    }
}
