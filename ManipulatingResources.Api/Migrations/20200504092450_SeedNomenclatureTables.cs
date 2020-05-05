using Microsoft.EntityFrameworkCore.Migrations;

namespace ManipulatingResources.Api.Migrations
{
    public partial class SeedNomenclatureTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO AccountsTypes (Description) Values ('Stream')");
            migrationBuilder
                .Sql("INSERT INTO AccountsTypes (Description) Values ('Credit')");
            migrationBuilder
                .Sql("INSERT INTO Coins (Description) Values ('MexicanPeso')");
            migrationBuilder
                .Sql("INSERT INTO Coins (Description) Values ('AmericanDollar')");
            migrationBuilder
                .Sql("INSERT INTO Coins (Description) Values ('Euro')");
            migrationBuilder
                .Sql("INSERT INTO Coins (Description) Values ('BitCoin')");
            migrationBuilder
                .Sql("INSERT INTO MovementsTypes (Description) Values ('Opening')");
            migrationBuilder
                .Sql("INSERT INTO MovementsTypes (Description) Values ('Deposit')");
            migrationBuilder
                .Sql("INSERT INTO MovementsTypes (Description) Values ('Retirement')");
            migrationBuilder
                .Sql("INSERT INTO MovementsTypes (Description) Values ('Interests')");
            migrationBuilder
                .Sql("INSERT INTO MovementsTypes (Description) Values ('Check')");
            migrationBuilder
                .Sql("INSERT INTO MovementsTypes (Description) Values ('Transfer')");
            migrationBuilder
                .Sql("INSERT INTO Status (Description) Values ('Disabled')");
            migrationBuilder
                .Sql("INSERT INTO Status (Description) Values ('Activated')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM AccountsTypes");
            migrationBuilder
                .Sql("DELETE FROM Coins");
            migrationBuilder
                .Sql("DELETE FROM MovementsTypes");
            migrationBuilder
                .Sql("DELETE FROM Status");
        }
    }
}
