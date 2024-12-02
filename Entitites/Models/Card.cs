using System.ComponentModel.DataAnnotations;

namespace Entitites.Models
{
    
    public class Card
    {
       public string CardName { get; set; }
        [MaxLength(4)]
       public int CardPin { get; set; }
        [MinLength(13)]
        [MaxLength(16)]
       public string CardPan { get; set; }
       public string City { get; set; }
       public string Country { get; set; }
        [MaxLength(3)]
       public string CountryCode { get; set; }
       public string ExpiryDate { get; set; }
        [MaxLength(3)]
       public string CVV { get; set; }
       public string PrimaryMobileCountryCode { get; set; }
       public string PrimaryMobileNumber { get; set; }
    }
}
