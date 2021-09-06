using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    public partial class inir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Company = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    EmailAddress = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    InfoContext = table.Column<string>(type: "text", nullable: true),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInfos_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReportDemandDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ReportStatusId = table.Column<int>(type: "integer", nullable: false),
                    ContactInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_ContactInfos_ContactInfoId",
                        column: x => x.ContactInfoId,
                        principalTable: "ContactInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_ReportStatuses_ReportStatusId",
                        column: x => x.ReportStatusId,
                        principalTable: "ReportStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Company", "Name", "Surname" },
                values: new object[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e"), "Odabaşı Soft", "Elif", "Odabaşıoğlu" });

            migrationBuilder.InsertData(
                table: "ReportStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Hazırlanıyor" },
                    { 2, "Tamamlandı" }
                });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "Id", "EmailAddress", "InfoContext", "Location", "PersonId", "PhoneNumber" },
                values: new object[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e"), "elifodabasi14@gmail.com", "Bilgi", "Ankara", new Guid("e98a2570-92e7-435e-a289-e5702987fa8e"), "05077217160" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "ContactInfoId", "ReportDemandDate", "ReportStatusId" },
                values: new object[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e"), new Guid("e98a2570-92e7-435e-a289-e5702987fa8e"), new DateTime(2021, 9, 5, 23, 19, 58, 529, DateTimeKind.Local).AddTicks(8282), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_PersonId",
                table: "ContactInfos",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ContactInfoId",
                table: "Reports",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportStatusId",
                table: "Reports",
                column: "ReportStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "ReportStatuses");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
