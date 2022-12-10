using Microsoft.EntityFrameworkCore;

namespace Intern_WebSixdo.Entities
{
    public class BillSales
    {
        public int BillSalesId { get; set; }
        public int? SalesId { get; set; }
        public Sales? Sales { get; set; }
        public int? BillId { get; set; }
        public Bill? Bill { get; set; }
    }
}
