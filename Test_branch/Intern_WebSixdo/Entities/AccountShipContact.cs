using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    [Index(nameof(AccountID), IsUnique = true)]
    public class AccountShipContact
    {
        public int AccountShipContactID { get; set; }
        public int? AccountID { get; set; }
        public Account? Account { get; set; }
        public string? ReceiverName { get; set; }
        public string? AccountDetailAddress { get; set; }
        //[Column(TypeName = "varchar")]
        public string? AccountPhoneNumber { get; set; }
        public int? AccountShipContactStatusId { get; set; }

    }
}
