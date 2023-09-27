using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonManagement.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PM01_Person",
                columns: table => new
                {
                    Id_person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IsEmployed = table.Column<bool>(type: "bit", nullable: true),
                    Id_maritalstatus = table.Column<int>(type: "int", nullable: true),
                    PlaceofBirth = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PM01_Person", x => x.Id_person);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PM01_Person");
        }
    }
}
