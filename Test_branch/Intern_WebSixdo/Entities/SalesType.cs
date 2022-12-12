using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class SalesType
    {
        public int SalesTypeId { get; set; }
        //[Column(TypeName = "varchar")]
        public string? SaleTypeCode { get; set; }
        public string? SalesTypeDetail { get; set; }
    }
}
