using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class BillStatus
    {
        public int BillStatusId { get; set; }
        public string? BillStatusCode { get; set; }
        public string? BillStatusDetail { get; set; }
    }
}
