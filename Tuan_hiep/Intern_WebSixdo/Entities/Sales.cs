using System;

namespace Intern_WebSixdo.Entities
{
    public class Sales
    {
        public int SalesId { get; set; }
        public string? SalesCode { get; set; }
        public string? SalesName { get; set; }
        public int? SalesPercent { get; set; }
        public int? SalesInt { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SalesStatusId { get; set; }
        public SalesStatus? SalesStatusStatus { get; set; }
        public int? SalesTypeId { get; set; }
        public SalesType? SalesType { get; set; }

    }
}
