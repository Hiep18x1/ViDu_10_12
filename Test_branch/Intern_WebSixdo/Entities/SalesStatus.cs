using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class SalesStatus
    {
        public int SalesStatusId { get; set; }
        //[Column(TypeName = "varchar")]
        public string? ProducerCode { get; set; }
        public string? ProducerDetail { get; set; }
    }
}
