using Microsoft.EntityFrameworkCore;

namespace Intern_WebSixdo.Entities
{
    public class VoteStar
    {
        public int VoteStarId { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public int? Accountid { get; set; }
        public Account? Account { get; set; }
        public int? StarVoted { get; set; }
    }
}
