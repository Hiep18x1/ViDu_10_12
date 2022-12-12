using Intern_WebSixdo.Entities;
using Microsoft.EntityFrameworkCore;
namespace Intern_WebSixdo.AppDbContext
{
    public class Context : DbContext
    {
        private string connection = "server=DESKTOP-3UR444R\\SQLEXPRESS;database=WebSixdo;trusted_connection=true;encrypt=false";
        public DbSet<AccountStatus> accountStatuses { get; set; }
        public DbSet<Role> Roles {get;set;}
        public DbSet<BuyMethod> buyMethods { get; set; }
        public DbSet<ShipMethod>  shipMethods { get; set; }

        public DbSet<BillStatus> billStatuses { get; set; }
        public DbSet<AccountBag> accountBags { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Bill> bills { get; set; }
        public DbSet<BillSales> billSales { get; set; }   
        public DbSet<VoteStar>  voteStars { get; set; }
        public DbSet<AccountShipContact> accountShipContacts { get; set; }
        public DbSet<BillDetail> billDetails { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesType> salesTypes { get; set; }
        public DbSet<CategoryType> categoryTypes { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<SalesStatus> salesStatuses { get; set; }
        public DbSet<ProductImg> productImgs { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Color> colors { get; set; }    
        public DbSet<Brand> brands { get; set; }
        public DbSet<ProductStatus> productStatuses { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

    }
}
