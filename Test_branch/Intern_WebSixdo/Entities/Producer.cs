using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class Producer
    {
        public int ProducerId { get; set; }
        //[Column(TypeName = "varchar")]
        public string? ProducerCode { get; set; }
        public string? ProducerDetail { get; set; }
    }
}
