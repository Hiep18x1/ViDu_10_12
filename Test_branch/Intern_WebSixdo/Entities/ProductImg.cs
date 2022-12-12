using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class ProductImg
    {
        public int ProductImgId { get; set; }
        public int? ProductId { get; set; }
        public int? CountImg { get; set; }
        public string? productImg { get; set; }
    }
}
