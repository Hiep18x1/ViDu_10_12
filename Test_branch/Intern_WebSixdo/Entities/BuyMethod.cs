using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class BuyMethod
    {
        public int BuyMethodId { get; set; }
        public string? BuyMethodCode { get; set; }
        public string? BuyMethodName { get; set; }
    }
}
