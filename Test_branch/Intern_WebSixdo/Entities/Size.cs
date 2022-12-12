using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class Size
    {
        public int SizeId { get; set; }
       // [Column(TypeName = "varchar")]
        public string? SizeCode { get; set; }
        public string? SizeDetail { get; set; }
    }
}
