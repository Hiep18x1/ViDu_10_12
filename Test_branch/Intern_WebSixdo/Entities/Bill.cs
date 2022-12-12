using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        public int? AccountShipContactID { get; set; }
        public AccountShipContact? AccountShipContact { get; set; }
        public int? BuyMethodId { get; set; }
        public BuyMethod? BuyMethod { get; set; }
        public DateTime CreateDate { get; set; }
        //[Column(TypeName = "date")]
        public DateTime ShiptoBuyerDate { get; set; }
        //[Column(TypeName = "date")]
        public DateTime ReceivedDate { get; set; }
        public DateTime CloseDate { get; set; }
        public int BillStatusID { get; set; }
        public BillStatus BillStatus { get; set;  }

        public DateTime? ProductReturnDate { get; set; }
        public string? Buyernotification { get; set; }
        public int? ShipMethodId { get; set; }
        public ShipMethod? ShipMethod { get; set; }
        public int? shipPrice { get; set; }
       // [Column(TypeName = "varchar")]
        public string? billCode { get; set; }
    }
}
