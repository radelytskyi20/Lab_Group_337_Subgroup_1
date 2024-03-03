using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    AcctNbr = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    Zip = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    DateOpen = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SsNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RiskLevel = table.Column<string>(type: "TEXT", nullable: true),
                    Occupation = table.Column<string>(type: "TEXT", nullable: true),
                    Objectives = table.Column<string>(type: "TEXT", nullable: true),
                    Interests = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.AcctNbr);
                });

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Symbol = table.Column<string>(type: "TEXT", nullable: false),
                    CoName = table.Column<string>(type: "TEXT", nullable: true),
                    Exchange = table.Column<string>(type: "TEXT", nullable: true),
                    CurPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    YrlHigh = table.Column<decimal>(type: "TEXT", nullable: false),
                    YrlLow = table.Column<decimal>(type: "TEXT", nullable: false),
                    PERatio = table.Column<decimal>(type: "TEXT", nullable: false),
                    Beta = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProjGrth = table.Column<int>(type: "INTEGER", nullable: false),
                    Industry = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceChg = table.Column<int>(type: "INTEGER", nullable: false),
                    Safety = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: true),
                    Bank = table.Column<int>(type: "INTEGER", nullable: false),
                    Outlook = table.Column<int>(type: "INTEGER", nullable: false),
                    Rcmndation = table.Column<string>(type: "TEXT", nullable: true),
                    Risk = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Symbol);
                });

            migrationBuilder.CreateTable(
                name: "Holdings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AcctNbr = table.Column<int>(type: "INTEGER", nullable: false),
                    Symbol = table.Column<string>(type: "TEXT", nullable: false),
                    Shares = table.Column<int>(type: "INTEGER", nullable: false),
                    PurPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    PurDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holdings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holdings_Clients_AcctNbr",
                        column: x => x.AcctNbr,
                        principalTable: "Clients",
                        principalColumn: "AcctNbr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Holdings_Masters_Symbol",
                        column: x => x.Symbol,
                        principalTable: "Masters",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Holdings_AcctNbr",
                table: "Holdings",
                column: "AcctNbr");

            migrationBuilder.CreateIndex(
                name: "IX_Holdings_Symbol",
                table: "Holdings",
                column: "Symbol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holdings");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Masters");
        }
    }
}
