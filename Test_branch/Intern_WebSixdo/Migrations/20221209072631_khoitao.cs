using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternWebSixdo.Migrations
{
    /// <inheritdoc />
    public partial class khoitao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accountStatuses",
                columns: table => new
                {
                    AccountStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountStatusDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountStatuses", x => x.AccountStatusId);
                });

            migrationBuilder.CreateTable(
                name: "billStatuses",
                columns: table => new
                {
                    BillStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillStatusDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billStatuses", x => x.BillStatusId);
                });

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "buyMethods",
                columns: table => new
                {
                    BuyMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyMethodCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buyMethods", x => x.BuyMethodId);
                });

            migrationBuilder.CreateTable(
                name: "categoryTypes",
                columns: table => new
                {
                    CategoryTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesTypeDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryTypes", x => x.CategoryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducerDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producers", x => x.ProducerId);
                });

            migrationBuilder.CreateTable(
                name: "productImgs",
                columns: table => new
                {
                    ProductImgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CountImg = table.Column<int>(type: "int", nullable: true),
                    productImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productImgs", x => x.ProductImgId);
                });

            migrationBuilder.CreateTable(
                name: "productStatuses",
                columns: table => new
                {
                    ProductStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStatusDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productStatuses", x => x.ProductStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "salesStatuses",
                columns: table => new
                {
                    SalesStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducerDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesStatuses", x => x.SalesStatusId);
                });

            migrationBuilder.CreateTable(
                name: "salesTypes",
                columns: table => new
                {
                    SalesTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesTypeDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesTypes", x => x.SalesTypeId);
                });

            migrationBuilder.CreateTable(
                name: "shipMethods",
                columns: table => new
                {
                    ShipMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipMethodCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipPrice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shipMethods", x => x.ShipMethodId);
                });

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountStatusID = table.Column<int>(type: "int", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountBorn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountDetailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcountCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_accounts_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_accounts_accountStatuses_AccountStatusID",
                        column: x => x.AccountStatusID,
                        principalTable: "accountStatuses",
                        principalColumn: "AccountStatusId");
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SalesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesPercent = table.Column<int>(type: "int", nullable: true),
                    SalesInt = table.Column<int>(type: "int", nullable: true),
                    OpenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesStatusId = table.Column<int>(type: "int", nullable: true),
                    SalesTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SalesId);
                    table.ForeignKey(
                        name: "FK_Sales_salesStatuses_SalesStatusId",
                        column: x => x.SalesStatusId,
                        principalTable: "salesStatuses",
                        principalColumn: "SalesStatusId");
                    table.ForeignKey(
                        name: "FK_Sales_salesTypes_SalesTypeId",
                        column: x => x.SalesTypeId,
                        principalTable: "salesTypes",
                        principalColumn: "SalesTypeId");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryTypeId = table.Column<int>(type: "int", nullable: true),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    ProducerId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    ShellPrice = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_products_brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brands",
                        principalColumn: "BrandId");
                    table.ForeignKey(
                        name: "FK_products_categoryTypes_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "categoryTypes",
                        principalColumn: "CategoryTypeId");
                    table.ForeignKey(
                        name: "FK_products_colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "colors",
                        principalColumn: "ColorId");
                    table.ForeignKey(
                        name: "FK_products_producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "producers",
                        principalColumn: "ProducerId");
                    table.ForeignKey(
                        name: "FK_products_productStatuses_ProductStatusId",
                        column: x => x.ProductStatusId,
                        principalTable: "productStatuses",
                        principalColumn: "ProductStatusId");
                    table.ForeignKey(
                        name: "FK_products_sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "sizes",
                        principalColumn: "SizeId");
                });

            migrationBuilder.CreateTable(
                name: "accountShipContacts",
                columns: table => new
                {
                    AccountShipContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    ReceiverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountDetailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountShipContactStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountShipContacts", x => x.AccountShipContactID);
                    table.ForeignKey(
                        name: "FK_accountShipContacts_accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "accounts",
                        principalColumn: "AccountID");
                });

            migrationBuilder.CreateTable(
                name: "accountBags",
                columns: table => new
                {
                    AccountBagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accountd = table.Column<int>(type: "int", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountBags", x => x.AccountBagId);
                    table.ForeignKey(
                        name: "FK_accountBags_accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "accounts",
                        principalColumn: "AccountID");
                    table.ForeignKey(
                        name: "FK_accountBags_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "voteStars",
                columns: table => new
                {
                    VoteStarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Accountid = table.Column<int>(type: "int", nullable: true),
                    StarVoted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voteStars", x => x.VoteStarId);
                    table.ForeignKey(
                        name: "FK_voteStars_accounts_Accountid",
                        column: x => x.Accountid,
                        principalTable: "accounts",
                        principalColumn: "AccountID");
                    table.ForeignKey(
                        name: "FK_voteStars_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountShipContactID = table.Column<int>(type: "int", nullable: true),
                    BuyMethodId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiptoBuyerDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillStatusID = table.Column<int>(type: "int", nullable: false),
                    ProductReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Buyernotification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipMethodId = table.Column<int>(type: "int", nullable: true),
                    shipPrice = table.Column<int>(type: "int", nullable: true),
                    billCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_bills_accountShipContacts_AccountShipContactID",
                        column: x => x.AccountShipContactID,
                        principalTable: "accountShipContacts",
                        principalColumn: "AccountShipContactID");
                    table.ForeignKey(
                        name: "FK_bills_billStatuses_BillStatusID",
                        column: x => x.BillStatusID,
                        principalTable: "billStatuses",
                        principalColumn: "BillStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bills_buyMethods_BuyMethodId",
                        column: x => x.BuyMethodId,
                        principalTable: "buyMethods",
                        principalColumn: "BuyMethodId");
                    table.ForeignKey(
                        name: "FK_bills_shipMethods_ShipMethodId",
                        column: x => x.ShipMethodId,
                        principalTable: "shipMethods",
                        principalColumn: "ShipMethodId");
                });

            migrationBuilder.CreateTable(
                name: "billDetails",
                columns: table => new
                {
                    BillDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billDetails", x => x.BillDetailId);
                    table.ForeignKey(
                        name: "FK_billDetails_bills_BillId",
                        column: x => x.BillId,
                        principalTable: "bills",
                        principalColumn: "BillId");
                    table.ForeignKey(
                        name: "FK_billDetails_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "billSales",
                columns: table => new
                {
                    BillSalesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesId = table.Column<int>(type: "int", nullable: true),
                    BillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billSales", x => x.BillSalesId);
                    table.ForeignKey(
                        name: "FK_billSales_Sales_SalesId",
                        column: x => x.SalesId,
                        principalTable: "Sales",
                        principalColumn: "SalesId");
                    table.ForeignKey(
                        name: "FK_billSales_bills_BillId",
                        column: x => x.BillId,
                        principalTable: "bills",
                        principalColumn: "BillId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_accountBags_AccountID",
                table: "accountBags",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_accountBags_ProductId",
                table: "accountBags",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_AccountStatusID",
                table: "accounts",
                column: "AccountStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_RoleID",
                table: "accounts",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_accountShipContacts_AccountID",
                table: "accountShipContacts",
                column: "AccountID",
                unique: true,
                filter: "[AccountID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_billDetails_BillId",
                table: "billDetails",
                column: "BillId",
                unique: true,
                filter: "[BillId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_billDetails_ProductId",
                table: "billDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_AccountShipContactID",
                table: "bills",
                column: "AccountShipContactID");

            migrationBuilder.CreateIndex(
                name: "IX_bills_BillStatusID",
                table: "bills",
                column: "BillStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_bills_BuyMethodId",
                table: "bills",
                column: "BuyMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_ShipMethodId",
                table: "bills",
                column: "ShipMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_billSales_BillId",
                table: "billSales",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_billSales_SalesId",
                table: "billSales",
                column: "SalesId");

            migrationBuilder.CreateIndex(
                name: "IX_products_BrandId",
                table: "products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryTypeId",
                table: "products",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ColorId",
                table: "products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProducerId",
                table: "products",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductStatusId",
                table: "products",
                column: "ProductStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_products_SizeId",
                table: "products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SalesStatusId",
                table: "Sales",
                column: "SalesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SalesTypeId",
                table: "Sales",
                column: "SalesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_voteStars_Accountid",
                table: "voteStars",
                column: "Accountid");

            migrationBuilder.CreateIndex(
                name: "IX_voteStars_ProductId",
                table: "voteStars",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountBags");

            migrationBuilder.DropTable(
                name: "billDetails");

            migrationBuilder.DropTable(
                name: "billSales");

            migrationBuilder.DropTable(
                name: "productImgs");

            migrationBuilder.DropTable(
                name: "voteStars");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "salesStatuses");

            migrationBuilder.DropTable(
                name: "salesTypes");

            migrationBuilder.DropTable(
                name: "accountShipContacts");

            migrationBuilder.DropTable(
                name: "billStatuses");

            migrationBuilder.DropTable(
                name: "buyMethods");

            migrationBuilder.DropTable(
                name: "shipMethods");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "categoryTypes");

            migrationBuilder.DropTable(
                name: "colors");

            migrationBuilder.DropTable(
                name: "producers");

            migrationBuilder.DropTable(
                name: "productStatuses");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "accountStatuses");
        }
    }
}
