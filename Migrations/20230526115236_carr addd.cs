using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PostgresDb.Migrations
{
    /// <inheritdoc />
    public partial class carraddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "DriverMedias");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "DriverMedias");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DriverMedias");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Drivers",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Drivers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Drivers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    CC = table.Column<int>(type: "integer", nullable: false),
                    DriverId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DriverId",
                table: "Cars",
                column: "DriverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Drivers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Drivers",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Teams",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Teams",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Teams",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Drivers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Drivers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "DriverMedias",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "DriverMedias",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DriverMedias",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
