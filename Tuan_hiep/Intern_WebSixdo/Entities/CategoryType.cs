using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class CategoryType
    {
        public int CategoryTypeId { get; set; }
        //[Column(TypeName = "varchar")]
        public string? SaleTypeCode { get; set; }
        public string? SalesTypeDetail { get; set; }
    }
}
