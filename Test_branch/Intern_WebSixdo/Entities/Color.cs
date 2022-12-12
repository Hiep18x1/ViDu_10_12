using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class Color
    {
        public int ColorId { get; set; }
        //[Column(TypeName = "varchar")]
        public string? ColorCode { get; set; }
        public string? ColorDetail { get; set; }
    }
}
