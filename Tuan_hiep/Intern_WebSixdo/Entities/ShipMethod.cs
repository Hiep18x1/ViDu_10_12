using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class ShipMethod
    {
        public int ShipMethodId { get; set; }

        public string? ShipMethodCode { get; set; }
        public string? ShipMethodName { get; set; }

        public int? ShipPrice { get; set; }
    }
}
