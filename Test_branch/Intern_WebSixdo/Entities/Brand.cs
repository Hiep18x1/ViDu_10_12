using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        //[Column(TypeName = "varchar")]
        public string? BrandCode { get; set; }
        public string? BrandDetail { get; set; }
    }
}
