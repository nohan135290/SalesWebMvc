using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class otherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BaseSalary = table.Column<double>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saller_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalerRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    StatusId = table.Column<int>(nullable: true),
                    SallerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalerRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalerRecords_Saller_SallerId",
                        column: x => x.SallerId,
                        principalTable: "Saller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalerRecords_SalerRecords_StatusId",
                        column: x => x.StatusId,
                        principalTable: "SalerRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalerRecords_SallerId",
                table: "SalerRecords",
                column: "SallerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalerRecords_StatusId",
                table: "SalerRecords",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Saller_DepartmentId",
                table: "Saller",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalerRecords");

            migrationBuilder.DropTable(
                name: "Saller");
        }
    }
}
