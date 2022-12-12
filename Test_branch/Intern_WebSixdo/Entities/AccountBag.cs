using Microsoft.EntityFrameworkCore;

namespace Intern_WebSixdo.Entities
{
    public class AccountBag
    {
        public int AccountBagId { get; set; }
        public int? Accountd { get; set; }
        public Account? Account { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public int? Quantity { get; set; }
    }
}
