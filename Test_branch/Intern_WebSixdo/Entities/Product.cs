using System;

namespace Intern_WebSixdo.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDetail { get; set; }
        public int? CategoryTypeId { get; set; }
        public CategoryType? CategoryType { get; set; }
        public int? SizeId { get; set; }
        public Size? Size { get; set; }
        public int? ColorId { get; set; }
        public Color? Color { get; set; }   
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int? ProducerId { get; set; }
        public Producer? Producer { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public int? ShellPrice { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? ProductStatusId { get; set; }
        public ProductStatus? ProductStatusStatus { get; set; }
    }
}
