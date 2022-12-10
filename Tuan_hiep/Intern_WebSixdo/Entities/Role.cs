using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intern_WebSixdo.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string? RoleCode { get; set; }

        public string? RoleDetail { get; set; }

    }
}
