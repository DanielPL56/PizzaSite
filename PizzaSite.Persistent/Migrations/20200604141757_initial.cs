using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaSite.Persistent.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Crust = table.Column<int>(nullable: false),
                    Sausage = table.Column<bool>(nullable: false),
                    Pepperoni = table.Column<bool>(nullable: false),
                    Onions = table.Column<bool>(nullable: false),
                    GreenPeppers = table.Column<bool>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmallSizeCost = table.Column<decimal>(nullable: false),
                    MediumSizeCost = table.Column<decimal>(nullable: false),
                    LargeSizeCost = table.Column<decimal>(nullable: false),
                    ThinCrustCost = table.Column<decimal>(nullable: false),
                    RegularCrustCost = table.Column<decimal>(nullable: false),
                    ThickCrustCost = table.Column<decimal>(nullable: false),
                    SausageCost = table.Column<decimal>(nullable: false),
                    PepperoniCost = table.Column<decimal>(nullable: false),
                    OnionsCost = table.Column<decimal>(nullable: false),
                    GreenPepperCost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}
