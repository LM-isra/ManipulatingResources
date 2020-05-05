using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManipulatingResources.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountsTypes",
                columns: table => new
                {
                    IdAccountType = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsTypes", x => x.IdAccountType);
                });

            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    IdCoin = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.IdCoin);
                });

            migrationBuilder.CreateTable(
                name: "MovementsTypes",
                columns: table => new
                {
                    IdMovementType = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementsTypes", x => x.IdMovementType);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    IdStatus = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    AllowCredit = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Limit = table.Column<decimal>(type: "decimal", nullable: false),
                    Phone = table.Column<string>(maxLength: 30, nullable: false),
                    IdStatus = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                    table.ForeignKey(
                        name: "FK_Clients_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    IdSupplier = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    CreditDays = table.Column<short>(nullable: false),
                    IdStatus = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.IdSupplier);
                    table.ForeignKey(
                        name: "FK_Suppliers_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountsReceivables",
                columns: table => new
                {
                    IdAccountReceivable = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal", nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DatePayment = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Invoice = table.Column<string>(maxLength: 20, nullable: false),
                    IdAccountType = table.Column<byte>(nullable: false),
                    IdClient = table.Column<Guid>(nullable: false),
                    IdCoin = table.Column<byte>(nullable: false),
                    IdMovementType = table.Column<byte>(nullable: false),
                    IdStatus = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsReceivables", x => x.IdAccountReceivable);
                    table.ForeignKey(
                        name: "FK_AccountsReceivables_Clients_IdAccountReceivable",
                        column: x => x.IdAccountReceivable,
                        principalTable: "Clients",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsReceivables_AccountsTypes_IdAccountType",
                        column: x => x.IdAccountType,
                        principalTable: "AccountsTypes",
                        principalColumn: "IdAccountType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsReceivables_Coins_IdCoin",
                        column: x => x.IdCoin,
                        principalTable: "Coins",
                        principalColumn: "IdCoin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsReceivables_MovementsTypes_IdMovementType",
                        column: x => x.IdMovementType,
                        principalTable: "MovementsTypes",
                        principalColumn: "IdMovementType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsReceivables_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "IdStatus");
                });

            migrationBuilder.CreateTable(
                name: "AccountsPayables",
                columns: table => new
                {
                    IdAccountPayable = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal", nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DatePayment = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Invoice = table.Column<string>(maxLength: 20, nullable: false),
                    IdAccountType = table.Column<byte>(nullable: false),
                    IdCoin = table.Column<byte>(nullable: false),
                    IdMovementType = table.Column<byte>(nullable: false),
                    IdSupplier = table.Column<Guid>(nullable: false),
                    IdStatus = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsPayables", x => x.IdAccountPayable);
                    table.ForeignKey(
                        name: "FK_AccountsPayables_Suppliers_IdAccountPayable",
                        column: x => x.IdAccountPayable,
                        principalTable: "Suppliers",
                        principalColumn: "IdSupplier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsPayables_AccountsTypes_IdAccountType",
                        column: x => x.IdAccountType,
                        principalTable: "AccountsTypes",
                        principalColumn: "IdAccountType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsPayables_Coins_IdCoin",
                        column: x => x.IdCoin,
                        principalTable: "Coins",
                        principalColumn: "IdCoin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsPayables_MovementsTypes_IdMovementType",
                        column: x => x.IdMovementType,
                        principalTable: "MovementsTypes",
                        principalColumn: "IdMovementType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsPayables_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "IdStatus");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountsPayables_IdAccountType",
                table: "AccountsPayables",
                column: "IdAccountType");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsPayables_IdCoin",
                table: "AccountsPayables",
                column: "IdCoin");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsPayables_IdMovementType",
                table: "AccountsPayables",
                column: "IdMovementType");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsPayables_IdStatus",
                table: "AccountsPayables",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsReceivables_IdAccountType",
                table: "AccountsReceivables",
                column: "IdAccountType");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsReceivables_IdCoin",
                table: "AccountsReceivables",
                column: "IdCoin");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsReceivables_IdMovementType",
                table: "AccountsReceivables",
                column: "IdMovementType");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsReceivables_IdStatus",
                table: "AccountsReceivables",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IdStatus",
                table: "Clients",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_IdStatus",
                table: "Suppliers",
                column: "IdStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsPayables");

            migrationBuilder.DropTable(
                name: "AccountsReceivables");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AccountsTypes");

            migrationBuilder.DropTable(
                name: "Coins");

            migrationBuilder.DropTable(
                name: "MovementsTypes");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
