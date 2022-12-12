using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class ProductStatus
    {
        public int ProductStatusId { get; set; }
        //[Column(TypeName = "varchar")]
        public string? ProductStatusCode { get; set; }
        public string? ProductStatusDetail { get; set; }
    }
}
