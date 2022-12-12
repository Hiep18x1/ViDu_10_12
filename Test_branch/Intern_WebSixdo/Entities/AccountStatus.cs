using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Intern_WebSixdo.Entities
{
    public class AccountStatus
    {
        public int AccountStatusId { get; set; }
        public string? AccountStatusCode { get; set; }
        public string? AccountStatusDetail { get; set; }
    }
}
