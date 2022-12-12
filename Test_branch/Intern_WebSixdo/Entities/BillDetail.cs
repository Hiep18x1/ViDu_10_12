using Microsoft.EntityFrameworkCore;

namespace Intern_WebSixdo.Entities
{
    [Index(nameof(BillId), IsUnique = true)]
    public class BillDetail
    {
        public int BillDetailId { get; set; }
        public int? BillId { get; set; }
        public Bill? Bill { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
    }
}
