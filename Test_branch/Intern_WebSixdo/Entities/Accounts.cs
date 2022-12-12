using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Intern_WebSixdo.Entities
{
    public class Account
    {
        public int AccountID { get; set; }

        //[Column(TypeName = "varchar")]
        public string? AccountUserName { get; set; }

        //[Column(TypeName = "varchar")]
        public string? AccountPassword { get; set; }
        public int? AccountStatusID { get; set; }
        public AccountStatus? AccountStatus { get; set; }
        public string? AccountName { get; set; }

        //[Column(TypeName = "date")]
        public DateTime? AccountBorn { get; set; }
        public string? AccountDetailAddress { get; set; }
        public DateTime? AcountCreateDate { get; set; }
        public int? RoleID { get; set; }
        public Role? Role { get; set; }

        //[Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        //[Column(TypeName = "date")]
        public DateTime? DpdateDate { get; set; }

    }
}
