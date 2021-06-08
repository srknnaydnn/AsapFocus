using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsapFocus.Migrations
{
    public partial class demos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_hs_ExpenseTypes",
                table: "hs_ExpenseTypes");

            migrationBuilder.RenameTable(
                name: "hs_ExpenseTypes",
                newName: "Hs_ExpenseTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hs_ExpenseTypes",
                table: "Hs_ExpenseTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "HS_CostOfFutures",
                columns: table => new
                {
                    DocNum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolcyNum = table.Column<int>(type: "int", nullable: false),
                    BegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstallmentNo = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HS_CostOfFutures", x => x.DocNum);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HS_CostOfFutures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hs_ExpenseTypes",
                table: "Hs_ExpenseTypes");

            migrationBuilder.RenameTable(
                name: "Hs_ExpenseTypes",
                newName: "hs_ExpenseTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hs_ExpenseTypes",
                table: "hs_ExpenseTypes",
                column: "Id");
        }
    }
}
